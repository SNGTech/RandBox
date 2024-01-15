using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RandBox.Shared.Domain;

namespace RandBox.Server.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.HasData(
                new Orders
                {
                    OrderID = 1,
                    DateTimeCheckout = DateTime.Now,
                    DeliveryStatus = true,
                    CustomerID = 1, 
                    StaffID = 1,
                    
                },
                new Orders
                {
                    OrderID = 2,
                    DateTimeCheckout = DateTime.Now,
                    DeliveryStatus = false,
                    CustomerID = 2,
                    StaffID = 2,

                }
            );
        }
    }
}
