using RandBox.Shared.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RandBox.Client.Services.Contracts
{
    public interface ISubscriptionPlanService : IGenericService<SubscriptionPlan>
    { 
        public Task<List<SubscriptionPlan>> UpdateStaffToNullOnSubscriptionPlan(Staff entity);
    }
}
