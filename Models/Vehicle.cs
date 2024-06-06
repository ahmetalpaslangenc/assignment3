using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleRegistrationApp.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        public string CarPlate { get; set; }

        [Required]
        public int Km { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string GearType { get; set; }

        [Required]
        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }
}
