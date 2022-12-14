using Microsoft.Build.Framework;

namespace HotelListingNEW.api.Models.Hotels
{
    public abstract class BaseHotelDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Adress { get; set; }
        public double? Rating { get; set; }
        [Required]
        public int CountryId { get; set; }
    }
        
    
}
