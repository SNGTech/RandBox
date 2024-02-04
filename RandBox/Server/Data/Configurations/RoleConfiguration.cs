using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RandBox.Server.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "645bb191-486c-4a9e-8f38-2a48b60b8df6",
                    Name = "Customer",
                    NormalizedName = "CUSTOMER",
                },
                new IdentityRole
                {
                    Id = "910da4f5-6826-419b-b66a-eb995b68bd15",
                    Name = "Staff",
                    NormalizedName = "STAFF",
                }
            );
        }
    }
}
