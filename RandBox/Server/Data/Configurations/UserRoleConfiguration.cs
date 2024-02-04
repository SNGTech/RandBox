using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace RandBox.Server.Data.Configurations
{
	public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
		{
			builder.HasData(
				new IdentityUserRole<string>
				{
					RoleId = "645bb191-486c-4a9e-8f38-2a48b60b8df6",
					UserId = "2c435063-eee0-40bb-bfeb-41051a581450"
				},
				new IdentityUserRole<string>
				{
					RoleId = "645bb191-486c-4a9e-8f38-2a48b60b8df6",
					UserId = "d9e7365f-8ec0-48d6-86b4-f5c95062b494"
				},
				new IdentityUserRole<string>
				{
					RoleId = "910da4f5-6826-419b-b66a-eb995b68bd15",
					UserId = "edc993c1-c4c7-458b-9870-e1a7af7361aa"
				},
				new IdentityUserRole<string>
				{
					RoleId = "910da4f5-6826-419b-b66a-eb995b68bd15",
					UserId = "9adbb6f1-b495-4fa3-86e2-7afb7de32fd4"
				}
			);
		}
	}
}
