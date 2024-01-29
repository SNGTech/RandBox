using RandBox.Shared.Domain;

namespace RandBox.Client.Services.Contracts
{
    public interface ICountryService : IGenericService<Country>
    {
        public Task<bool> IsCountryReferenced(int countryId);
    }
}
