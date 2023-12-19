using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RandBox.Shared.Domain;

namespace RandBox.Server.Data.Configurations
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    StaffID = 1,
                    FirstName = "Shan",
                    LastName = "Lim",
                    Email = "Shan2209@gmail.com",
                    PasswordHash = "",
                    DateOfBirth = new DateTime(2005, 12, 27),
                    ContactNumber = "81004821"
                    
                },
                new Staff
                {
                    StaffID = 2,
                    FirstName = "Atu",
                    LastName = "Triyoso",
                    Email = "AtuTriyoso@gmail.com",
                    PasswordHash = "",
                    DateOfBirth = new DateTime(2005, 2, 27),
                    ContactNumber ="91028765"
                    
                }
            );
        }
    }
}
