using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parking;

namespace ParkingWeb.Controllers
{
    [Produces("application/json")]
    [Route("api/Transactions")]
    public class TransactionsController : Controller
    {
        [Route("get_transaction_log")]
        [HttpGet]
        public string GetTransactionLog()
        {
            string line;
            using (StreamReader sr = new StreamReader("Transactions.log", System.Text.Encoding.Default))
            {
                line = sr.ReadToEnd();
            }
            return line;
        }
        [Route("get_last_minute_transactions")]
        [HttpGet]
        public IEnumerable<Transaction> GetLastMinuteTransactions()
        {
            IEnumerable<Transaction> lastMinuteTransactins = Parking.Parking.Instance.GetLastMinuteTransactions();
            return lastMinuteTransactins;
        }

        [Route("get_last_minute_transactions/{id}")]
        [HttpGet]
        public IEnumerable<Transaction> GetLastMinuteTransactionsById(uint id)
        {
            IEnumerable<Transaction> lastMinuteTransactins = Parking.Parking.Instance.GetLastMinuteTransactions()
                .Where<Transaction>(t => t.CarId == id);
            return lastMinuteTransactins;
        }

        [Route("give_car_money/{id}/{value}")]
        [HttpPut]
        public string Put(uint id, decimal value)
        {
            Parking.Parking.Instance.AddCarMoney(id, value);
            return "putted!";
        }
        
    }
}
