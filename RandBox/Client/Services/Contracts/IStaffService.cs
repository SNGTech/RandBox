using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
    public interface IStaffService : IGenericService<Staff>
    {
       
        public Task<List<Orders>> GetOrdersByStaffId(int staffId);
    }
}
