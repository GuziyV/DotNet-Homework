using System;
using System.Collections.Generic;
using System.IO;
using System.Json;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parking;

namespace ParkingWeb.Controllers
{
    [Produces("application/json")]
    public class TransactionsController : Controller
    {
        [HttpGet]
        public IEnumerable<string> GetTransactionLog()
        {
            List<string> JsonLogs = new List<string>();
            string line;
            using (StreamReader sr = new StreamReader("Transactions.log", System.Text.Encoding.Default))
            {
                line = sr.ReadLine();
                while (line != null)
                {
                    JsonLogs.Add(Services.JsonLogParser.Parse(line));
                    line = sr.ReadLine();
                }
            }
            return JsonLogs;

        }
        [HttpGet]
        public IEnumerable<Transaction> GetLastMinuteTransactions()
        {
            IEnumerable<Transaction> lastMinuteTransactins = Parking.Parking.Instance.GetLastMinuteTransactions();
            return lastMinuteTransactins;
        }

        [HttpGet]
        public IEnumerable<Transaction> GetLastMinuteTransactionsById(uint id)
        {
            IEnumerable<Transaction> lastMinuteTransactins = Parking.Parking.Instance.GetLastMinuteTransactions()
                .Where<Transaction>(t => t.CarId == id);
            return lastMinuteTransactins;
        }

        [HttpPut]
        public string AddCarMoney(uint id, decimal value)
        {
            return Parking.Parking.Instance.AddCarMoney(id, value);
        }
        
    }
}
