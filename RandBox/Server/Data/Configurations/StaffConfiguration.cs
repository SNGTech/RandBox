using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RandBox.Server.Models;
using RandBox.Shared.Domain;

namespace RandBox.Server.Data.Configurations
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new Staff
                {
                    StaffID = 1,
                    FirstName = "Bob",
                    LastName = "Lim",
                    Email = "test@randbox.sg",
                    PasswordHash = hasher.HashPassword(null, "Password123"),
                    DateOfBirth = new DateTime(2005, 12, 27),
                    ContactNumber = "81004821"
                    
                },
                new Staff
                {
                    StaffID = 2,
                    FirstName = "Atu",
                    LastName = "Triyoso",
                    Email = "atutriyoso@randbox.sg",
                    PasswordHash = hasher.HashPassword(null, "Password123"),
                    DateOfBirth = new DateTime(2005, 2, 27),
                    ContactNumber ="91028765"
                }
            );
        }
    }
}
