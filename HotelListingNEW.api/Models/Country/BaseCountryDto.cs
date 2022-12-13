using Microsoft.Build.Framework;

namespace HotelListingNEW.api.Models.Country
{
    public abstract  class BaseCountryDto
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
