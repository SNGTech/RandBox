using Microsoft.AspNetCore.Identity;

namespace RandBox.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string? FirstName { get; set; }
        [PersonalData]
        public string? LastName { get; set; }
        [PersonalData]
        public DateTime DateOfBirth { get; set; }
        [PersonalData]
        public string? Address { get; set; }
        [PersonalData]
        public string? UnitNo { get; set; }
        [PersonalData]
        public string? PostalCode { get; set; }
    }
}