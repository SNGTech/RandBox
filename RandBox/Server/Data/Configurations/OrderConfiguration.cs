using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RandBox.Shared.Domain;

namespace RandBox.Server.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                new Order
                {
                    OrderID = 1,
                    DateTimeCheckout = DateTime.Now,
                    DeliveryStatus = true,
                    CustomerID = 1, 
                    StaffID = 1,
                    
                },
                new Order
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
