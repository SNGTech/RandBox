using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RandBox.Shared.Domain;

namespace RandBox.Server.Data.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasData(
                new OrderItem
                {
                    OrderItemID = 1,
                    Qty = 2,
                    OrderID = 1,
                    ProductID = 1,

                    
                },
                new OrderItem
                {
                    OrderItemID = 2,
                    Qty = 4,
                    OrderID = 2,
                    ProductID = 2,

                }
            );
        }
    }
}
