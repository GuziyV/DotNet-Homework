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
    [Route("api/Car")]
    public class CarsController : Controller
    {
        // GET: api/Cars
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return Parking.Parking.Instance.GetAllCars();
        }

        // GET: api/Cars/5
        [HttpGet("{id}", Name = "Get")]
        public Car Get(int id)
        {
            return Parking.Parking.Instance.GetCarById(id);
        }
        
        // POST: api/Car
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Cars/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
