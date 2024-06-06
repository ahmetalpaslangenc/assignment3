using System.ComponentModel.DataAnnotations;

namespace VehicleRegistrationApp.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
