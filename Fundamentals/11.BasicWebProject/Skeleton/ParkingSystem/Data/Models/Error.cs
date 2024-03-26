using System.ComponentModel.DataAnnotations;

namespace ParkingSystem.Data.Models
{
    public class Error
    {
        [Required]
        public string? Message { get; set; }
        
        public Error(string message)
        {
            this.Message = message;
        }
    }
}
