using System.Linq.Expressions;

namespace RandBox.Client.Services.Contracts
{
	public interface IGenericService<T> where T : class
	{
		Task<T> GetByOrderId(int id);
		Task<List<T>> GetAll();
		Task<T> Insert(T entity);
		Task<string> DeleteById(int id);
		Task<T> Update(T entity);
	}
}
