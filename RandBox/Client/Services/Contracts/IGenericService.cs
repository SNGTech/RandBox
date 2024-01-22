using System.Linq.Expressions;

namespace RandBox.Client.Services.Contracts
{
	public interface IGenericService<T> where T : class
	{
        public HttpInterceptorService _httpInterceptorService { get; set; }

        Task<T> GetById(int id);
		Task<List<T>> GetAll();
		Task<T> Insert(T entity);
		Task<string> DeleteById(int id);
		Task<T> Update(T entity);
	}
}
