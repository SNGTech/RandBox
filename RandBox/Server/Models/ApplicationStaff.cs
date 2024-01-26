using Microsoft.AspNetCore.Identity;

namespace RandBox.Server.Models
{
    public class ApplicationStaff : IdentityUser
    {
        [PersonalData]
        public string? FirstName { get; set; }
        [PersonalData]
        public string? LastName { get; set; }
        [PersonalData]
        public DateTime DateOfBirth { get; set; }
        [PersonalData]
        public string? ContactNo { get; set; }
    }
}
