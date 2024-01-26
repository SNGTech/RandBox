// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using RandBox.Server.Models;
using RandBox.Server.Services;
using RandBox.Server.Services.Contracts;

namespace RandBox.Server.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly IUserEmailStore<ApplicationUser> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly IStripeCustomerService _stripeCustomerService;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            IUserStore<ApplicationUser> userStore,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager,
            IStripeCustomerService stripeCustomerService)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;

            _stripeCustomerService = stripeCustomerService;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            // randBox Field: FirstName
            [Required(ErrorMessage = "First Name required")]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            // randBox Field: LastName
            [Required(ErrorMessage = "Last Name required")]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            // randBox Field: Date of Birth
            [Required(ErrorMessage = "Date of Birth required")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
            [Display(Name = "Date of Birth")]
            public System.DateTime DateOfBirth { get; set; }

            // randBox Field: Address
            [Required(ErrorMessage = "Address required")]
            [Display(Name = "Address")]
            public string Address { get; set; }

            // randBox Field: Unit No
            [Required(ErrorMessage = "Unit No. required")]
            [Display(Name = "Unit No.")]
            public string UnitNo { get; set; }

            // randBox Field: Postal Code
            [Required(ErrorMessage = "Postal code required")]
            [RegularExpression(@"\d{6}", ErrorMessage = "Invalid Postal Code")]
            [Display(Name = "Postal Code")]
            public string PostalCode { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }


        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = CreateUser();

                user.FirstName = Input.FirstName;
                user.LastName = Input.LastName;
                user.DateOfBirth = Input.DateOfBirth;
                user.Address = Input.Address;
                user.UnitNo = Input.UnitNo;
                user.PostalCode = Input.PostalCode;

                await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    // Add role to user based one Email Suffix
                    var role = "Customer";
                    if (role != null)
                    {
                        IdentityResult roleResult = await _userManager.AddToRoleAsync(user, role);
                        if (roleResult.Succeeded)
                        {
                            _logger.LogInformation("Assigned {RoleName} Role to user.", role);

                            /*// Add Stripe Customer if Role is Customer
                            if (role.Name == "Customer")
                            {
                                await _stripeCustomerService.CreateCustomerAsync(user);
                            }*/
                        }
                        else
                        {
                            _logger.LogWarning("Failed to assign {{RoleName}} Role to user!", role);
                        }
                    }
                    else
                    {
                        _logger.LogWarning("Failed to assign role to user: {RoleName} Role not found!", role);
                    }

                    _logger.LogInformation("User created a new account with password.");

                    var userId = await _userManager.GetUserIdAsync(user);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        // Create claims for Customer Role
                        var claims = new Claim[]
                        {
                            new Claim(ClaimTypes.Email, user.Email),
                            new Claim("FullName", user.FirstName + " " + user.LastName),
                            new Claim(ClaimTypes.Role, role)
                        };

                        /*var authProperties = new AuthenticationProperties
                        {
                            AllowRefresh = true,
                            IsPersistent = false
                        };

                        await HttpContext.SignInAsync(
                            CookieAuthenticationDefaults.AuthenticationScheme,
                            claim,
                            authProperties
                        );*/

                        await _signInManager.SignInWithClaimsAsync(user, isPersistent: false, claims);
                        _logger.LogInformation("User {Email} logged in at {Time}.",
                            user.Email, DateTime.UtcNow);

                        return LocalRedirect(returnUrl);
                    }   
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private ApplicationUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<ApplicationUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(ApplicationUser)}'. " +
                    $"Ensure that '{nameof(ApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<ApplicationUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<ApplicationUser>)_userStore;
        }
    }
}
