using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePayments
{
    public class Payment : IPayment
    {
        private Dictionary<DateTime, int> readings;

        public Payment(string type)
        {
            Type = type;
            readings = new Dictionary<DateTime, int>();
        }
        
        public string Type { get; set; }

        public void SubmitReadings(int currentReadings)
        {
            readings.Add(DateTime.UtcNow, currentReadings);
        }
    }
}
