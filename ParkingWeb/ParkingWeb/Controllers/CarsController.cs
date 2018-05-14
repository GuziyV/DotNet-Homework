using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        public string GetCar(int id)
        {
            Car c = Parking.Parking.Instance.GetCarById(id);
            if (c == null)
            {
                return "cant find a car with such id";
            }
            else
            {
                return JsonConvert.SerializeObject(c);
            }
        }
        [HttpPost]
        public string AddCar(uint id, decimal amount, string type)
        {
            if (Parking.Parking.Instance.IsIdOfCarExist(id))
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
            return Parking.Parking.Instance.AddCar(new Car(id, cType, amount));
        }

        [HttpDelete]
        public string DeleteCar(uint id)
        {
            return Parking.Parking.Instance.DeleteCar(id);
        }
    }
}
