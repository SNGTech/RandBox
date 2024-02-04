using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RandBox.Server.Models;

namespace RandBox.Server.Data.Configurations
{
	public class UserAccountConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{
		public void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
			var hasher = new PasswordHasher<ApplicationUser>();
			builder.HasData(
				new ApplicationUser
				{
					Id = "2c435063-eee0-40bb-bfeb-41051a581450",
					FirstName = "Titus",
					LastName = "Lim",
					Email = "cout.sngtech@gmail.com",
					DateOfBirth = new DateTime(2005, 1, 20),
					Address = "Lane Road 2",
					UnitNo = "04-06",
					PostalCode = "342352",
					UserName = "cout.sngtech@gmail.com",
					NormalizedEmail = "COUT.SNGTECH@GMAIL.COM",
					NormalizedUserName = "COUT.SNGTECH@GMAIL.COM",
					PasswordHash = hasher.HashPassword(null, "Password123")
				},
				new ApplicationUser
				{
					Id = "d9e7365f-8ec0-48d6-86b4-f5c95062b494",
					FirstName = "Patrick",
					LastName = "Wu",
					Email = "patrick_wu@gmail.com",
					DateOfBirth = new DateTime(2005, 4, 13),
					Address = "Hoppa Avenue 8",
					UnitNo = "23-45",
					PostalCode = "442532",
					UserName = "patrick_wu@gmail.com",
					NormalizedEmail = "PATRICK_WU@GMAIL.COM",
					NormalizedUserName = "PATRICK_WU@GMAIL.COM",
					PasswordHash = hasher.HashPassword(null, "Password123")
				},
				new ApplicationUser
				{
					Id = "edc993c1-c4c7-458b-9870-e1a7af7361aa",
					FirstName = "Bob",
					LastName = "Lim",
					Email = "test@randbox.sg",
					DateOfBirth = new DateTime(2005, 1, 20),
					Address = "",
					UnitNo = "",
					PostalCode = "",
					UserName = "test@randbox.sg",
					NormalizedEmail = "TEST@RANDBOX.SG",
					NormalizedUserName = "TEST@RANDBOX.SG",
					PasswordHash = hasher.HashPassword(null, "Password123")
				},
				new ApplicationUser
				{
					Id = "9adbb6f1-b495-4fa3-86e2-7afb7de32fd4",
					FirstName = "Atu",
					LastName = "Triyoso",
					Email = "atutriyoso@randbox.sg",
					DateOfBirth = new DateTime(2005, 4, 13),
					Address = "Hoppa Avenue 8",
					UnitNo = "23-45",
					PostalCode = "442532",
					UserName = "atutriyoso@randbox.sg",
					NormalizedEmail = "ATUTRIYOSO@RANDBOX.SG",
					NormalizedUserName = "ATUTRIYOSO@RANDBOX.SG",
					PasswordHash = hasher.HashPassword(null, "Password123")
				}
			);
		}
	}
}
