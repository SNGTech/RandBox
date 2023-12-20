using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using RandBox.Server.Data;
using RandBox.Server.Repositories.Contracts;
using System.Linq.Expressions;

namespace RandBox.Server.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly ApplicationDbContext _context;
		private readonly DbSet<T> _dbSet;

		public GenericRepository(ApplicationDbContext context)
		{
			_context = context;
			_dbSet = _context.Set<T>();
		}

		public async Task DeleteById(int id)
		{
			var entityById = await _dbSet.FindAsync(id);
			_dbSet.Remove(entityById!);
		}

		public void DeleteRange(IEnumerable<T> entities)
		{
			_dbSet.RemoveRange(entities);
		}

		public async Task<T> GetById(int id)
		{
			var entity = await _dbSet.FindAsync(id);

			return entity!;
		}

		// No tracking of saved changes since it is read-only
		public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null)
		{
			IQueryable<T> query = _dbSet;
			
			if (filter != null)
			{
				query = query.Where(filter);
			}

			if (includes != null)
			{
				query = includes(query);
			}

			if (orderBy != null)
			{
				query = orderBy(query);
			}

			return await query.AsNoTracking().ToListAsync();
		}

		public async Task Insert(T entity)
		{
			await _dbSet.AddAsync(entity);
		}

		public async Task InsertRange(IEnumerable<T> entities)
		{
			await _dbSet.AddRangeAsync(entities);
		}

		public void Update(T entity)
		{
			_dbSet.Attach(entity);
			_context.Entry(entity).State = EntityState.Modified;
		}
	}
}
