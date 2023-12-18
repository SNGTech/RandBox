using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RandBox.Shared.Domain;

namespace RandBox.Server.Data.Configurations
{
	public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
	{
		public void Configure(EntityTypeBuilder<Customer> builder)
		{
			builder.HasData(
				new Customer
				{
					CustID = 1,
					FirstName = "Titus",
					LastName = "Lim",
					Email = "cout.sngtech@gmail.com",
					PasswordHash = "",
					DateOfBirth = new DateTime()
				},
				new Customer
				{

				}
			);
		}
	}
}
