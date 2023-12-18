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
					DateOfBirth = new DateTime(2005, 1, 20),
					Address = "Lane Road 2",
					UnitNo = "04-06",
					PostalCode = "342352",
					DateTimeCreated = DateTime.Now
				},
				new Customer
				{
					CustID = 2,
					FirstName = "Patrick",
					LastName = "Wu",
					Email = "patrick_wu@gmail.com",
					PasswordHash = "",
					DateOfBirth = new DateTime(2005, 4, 13),
                    Address = "Hoppa Avenue 8",
                    UnitNo = "23-45",
                    PostalCode = "442532",
                    DateTimeCreated = DateTime.Now
                }
			);
		}
	}
}
