using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParkingWeb.Controllers
{
    [Produces("application/json")]
    public class ParkingController : Controller
    {
        [HttpGet]
        public int GetfreeSpaces()
        {
            return Parking.Settings.ParkingSpace - Parking.Parking.Instance.GetNumberOfCars();
        }

        [HttpGet]
        public int GetNumberOfCars()
        {
            return Parking.Parking.Instance.GetNumberOfCars();
        }

        [HttpGet]
        public decimal GetParkingBalance()
        {
            return Parking.Parking.Instance.Balance;
        }
        

    }
}
