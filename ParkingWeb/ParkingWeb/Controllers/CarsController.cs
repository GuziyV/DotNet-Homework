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
    [Route("api/Cars")]
    public class CarsController : Controller
    {
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return Parking.Parking.Instance.GetAllCars();
        }

        [Route("get_car/{id}")]
        [HttpGet]
        public Car Get(int id)
        {
            return Parking.Parking.Instance.GetCarById(id);
        }
        
        [HttpPost]
        [Route("add_car/{id:int}/{type}/{amount:decimal}")]
        public string Post(int id, string type, int amount)
        {
            if (Parking.Parking.Instance.IsIdOfCarExist(UInt32.Parse(id.ToString())))
            {
                throw new WrongCommandException("Id is already exists");
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
                    throw new WrongTypeOfCarException("Wrong type of car");
            }
            Parking.Parking.Instance.AddCar(new Car(UInt32.Parse(id.ToString()), cType, amount));
            return "Car added!";
        }
  
        [HttpDelete]
        [Route("delete/{id}")]
        public void Delete(uint id)
        {
            Parking.Parking.Instance.DeleteCar(id);
        }
    }
}
