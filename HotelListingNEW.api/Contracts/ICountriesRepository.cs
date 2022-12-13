using HotelListingNEW.api.Data;

namespace HotelListingNEW.api.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {

        Task<Country> GetDetails(int id);

    }
}
