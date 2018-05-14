using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingWeb.Services
{
    public static class JsonLogParser
    {
        class LogLine
        {
            public LogLine(decimal sum, DateTime date)
            {
                Sum = sum;
                Date = date;
            }
            public decimal Sum;
            public DateTime Date;
        }

        static public string Parse(string logLine)
        {
            string[] arr = logLine.Split();
            string date = arr[3] + " " + arr[4] + " " + arr[5];
            string sum = arr[7];
            string res = JsonConvert.SerializeObject(new LogLine(Decimal.Parse(sum), DateTime.Parse(date)));
            return res;
        }
    }
}
