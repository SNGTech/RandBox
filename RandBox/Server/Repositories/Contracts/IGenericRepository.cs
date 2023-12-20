using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace RandBox.Server.Repositories.Contracts
{
	public interface IGenericRepository<T> where T : class
	{
		Task<T> GetById(int id);
		Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null);
		Task Insert(T entity);
		Task InsertRange(IEnumerable<T> entities);
		Task DeleteById(int id);
		void DeleteRange(IEnumerable<T> entities);
		void Update(T entity);
	}
}
