using Microsoft.EntityFrameworkCore;
using RandBox.Server.Data;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;

namespace RandBox.Server.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext _context;
		private IGenericRepository<Customer>? customerRepository;
		private IGenericRepository<Staff>? staffRepository;
		private IGenericRepository<Product>? productRepository;
		private IGenericRepository<Order>? orderRepository;
		private IGenericRepository<OrderItem>? orderItemRepository;
		private IGenericRepository<Category>? categoryRepository;
		private IGenericRepository<Country>? countryRepository;
		private IGenericRepository<SubscriptionPlan>? planRepository;
		private IGenericRepository<SubscriptionCategory>? subscriptionCategoryRepository;
		private IGenericRepository<SubscriptionItem>? subscriptionItemRepository;

		public UnitOfWork(ApplicationDbContext context) 
		{
			_context = context;
		}

		public IGenericRepository<Customer> CustomerRepository
			=> customerRepository ??= new GenericRepository<Customer>(_context);
		public IGenericRepository<Staff> StaffRepository
			=> staffRepository ??= new GenericRepository<Staff>(_context);
		public IGenericRepository<Product> ProductRepository
			=> productRepository ??= new GenericRepository<Product>(_context);
		public IGenericRepository<Order> OrderRepository
			=> orderRepository ??= new GenericRepository<Order>(_context);
		public IGenericRepository<OrderItem> OrderItemRepository
			=> orderItemRepository ??= new GenericRepository<OrderItem>(_context);
		public IGenericRepository<Category> CategoryRepository
			=> categoryRepository ??= new GenericRepository<Category>(_context);
		public IGenericRepository<Country> CountryRepository
			=> countryRepository ??= new GenericRepository<Country>(_context);
		public IGenericRepository<SubscriptionPlan> PlanRepository
			=> planRepository ??= new GenericRepository<SubscriptionPlan>(_context);
		public IGenericRepository<SubscriptionCategory> SubscriptionCategoryRepository
			=> subscriptionCategoryRepository ??= new GenericRepository<SubscriptionCategory>(_context);
		public IGenericRepository<SubscriptionItem> SubscriptionItemRepository
			=> subscriptionItemRepository ??= new GenericRepository<SubscriptionItem>(_context);

		public void Dispose()
		{
			_context.Dispose();
			GC.SuppressFinalize(this);
		}

		public async Task Save()
		{
			//////////////////////// UNUSED ////////////////////////
			/*// Obtain entries that were recently added
			var addedEntries = _context.ChangeTracker.Entries()
				.Where(q => q.State == EntityState.Added);

			for (var entry in addedEntries)
			{

			}*/
			////////////////////////////////////////////////////////

			await _context.SaveChangesAsync();
		}
	}
}
