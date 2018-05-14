using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parking;

namespace ParkingWeb.Controllers
{
    [Produces("application/json")]
    public class CarsController : Controller
    {
        [HttpGet]
        public IEnumerable<Car> GetAllCars()
        {
            return Parking.Parking.Instance.GetAllCars();
        }

        [HttpGet]
        public Car GetCar(int id)
        {
            return Parking.Parking.Instance.GetCarById(id);
        }
        [HttpPost]
        public string AddCar(int id, decimal amount, string type)
        {
            if (Parking.Parking.Instance.IsIdOfCarExist(UInt32.Parse(id.ToString())))
            {
                return "Id is already exists";
            }
            CarType cType;

            switch (type.ToLower())
            {
                case "passenger":
                    cType = CarType.Passenger;
                    break;
                case "truck":
                    cType = CarType.Truck;
                    break;
                case "bus":
                    cType = CarType.Bus;
                    break;
                case "motorcycle":
                    cType = CarType.Motorcycle;
                    break;
                default:
                    return "Wrong type of car";
            }
            Parking.Parking.Instance.AddCar(new Car(UInt32.Parse(id.ToString()), cType, amount));
            return "Car added!";
        }
  
        [HttpDelete]
        public string DeleteCar(uint id)
        {
            Parking.Parking.Instance.DeleteCar(id);
            return "removed";
        }
    }
}
