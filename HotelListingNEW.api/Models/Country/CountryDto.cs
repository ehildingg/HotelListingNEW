using HotelListingNEW.api.Models.Hotels;

namespace HotelListingNEW.api.Models.Country
{
    public class CountryDto : BaseCountryDto
    {
        public int Id { get; set; }
       
        public List<HotelDto> Hotels { get; set; }
    }

   
}
