using System.ComponentModel.DataAnnotations;

namespace ParkingSystem.Data.Models
{
    public class Car
    {
        [Required]
        public string? Make { get; set; }

        [Required]
        public string? Model { get; set; }

        [Required]
        public string? PlateNumber { get; set; }
    }
}
