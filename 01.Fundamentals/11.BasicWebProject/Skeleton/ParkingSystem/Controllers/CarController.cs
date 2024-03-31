using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ParkingSystem.Data;
using ParkingSystem.Data.Models;

namespace ParkingSystem.Controllers
{
    public class CarController : Controller
    {
        [HttpPost]
        public IActionResult Add(Car car)
        {
            if (DataAccess.Cars.Count == 4)
            {
                TempData["ErrorMessage"] = "Only space for 4 cars in the lot!";
            }
            else if(ModelState.IsValid && DataAccess.Cars.FirstOrDefault(x => x.PlateNumber == car.PlateNumber) == null)
            {
                DataAccess.Cars.Add(car);
            } 
            else
            {
                TempData["ErrorMessage"] = "Car already in the lot or the input was invalid!";
            }

            return Redirect("/");
        }

        [HttpPost]
        public IActionResult Delete(string plateNumber)
        {
            var car = DataAccess.Cars.FirstOrDefault(car => car.PlateNumber == plateNumber);
            DataAccess.Cars.Remove(car!);
            
            return Redirect("/");
        }
    }
}
