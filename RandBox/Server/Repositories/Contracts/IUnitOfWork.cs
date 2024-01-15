using RandBox.Shared.Domain;

namespace RandBox.Server.Repositories.Contracts
{
	public interface IUnitOfWork : IDisposable
	{
		IGenericRepository<Customer> CustomerRepository { get; }
		IGenericRepository<Staff> StaffRepository { get; }
		IGenericRepository<Product> ProductRepository { get; }
		IGenericRepository<Orders> OrderRepository { get; }
		IGenericRepository<OrderItem> OrderItemRepository { get; }
		IGenericRepository<Category> CategoryRepository { get; }

		IGenericRepository<Country> CountryRepository { get; }
		IGenericRepository<SubscriptionPlan> PlanRepository { get; }
		IGenericRepository<SubscriptionCategory> SubscriptionCategoryRepository { get; }
		IGenericRepository<SubscriptionItem> SubscriptionItemRepository { get; }

		Task Save();
	}
}
