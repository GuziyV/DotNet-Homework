using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParkingWeb.Controllers
{
    [Produces("application/json")]
    [Route("api/Parking")]
    public class ParkingController : Controller
    {
        [Route("get_free_spaces")]
        [HttpGet]
        public int GetfreeSpaces()
        {
            return Parking.Settings.ParkingSpace - Parking.Parking.Instance.GetNumberOfCars();
        }

        [Route("get_number_of_cars")]
        [HttpGet]
        public int GetNumberOfCars()
        {
            return Parking.Parking.Instance.GetNumberOfCars();
        }

        [Route("get_parking_balance")]
        [HttpGet]
        public decimal GetParkingBalance()
        {
            return Parking.Parking.Instance.Balance;
        }
        

    }
}
