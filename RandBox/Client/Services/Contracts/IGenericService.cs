using System.Linq.Expressions;

namespace RandBox.Client.Services.Contracts
{
	public interface IGenericService<T> where T : class
	{
		Task<T> GetById(int id);
		Task<List<T>> GetAll();
		Task<T> Insert(T entity);
		Task<IEnumerable<T>> InsertRange(IEnumerable<T> entities);
		Task<T> DeleteById(int id);
		Task<IEnumerable<T>> DeleteRange(IEnumerable<T> entities);
		Task<T> Update(T entity);
	}
}
