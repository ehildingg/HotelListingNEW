using HotelListingNEW.api.Contracts;
using HotelListingNEW.api.Data;

namespace HotelListingNEW.api.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
