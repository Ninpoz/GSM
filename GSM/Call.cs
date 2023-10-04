using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    public class Call
    {
       public DateTime Date { get; set; }
       public TimeSpan Time { get; set; }
       public string PhoneNumber { get; set; }
       public int CallDuration { get; set; }

        public Call(DateTime date, TimeSpan time, string phoneNumber, int callduration)
        {
            Date = date;
            Time = time;
            PhoneNumber = phoneNumber;
            CallDuration = callduration;

        }

        public string GetCallInfo()
        {
          return  $"Datum: {Date.ToShortDateString()}\n" +
              $"Tid: {Time.ToString(@"hh\:mm\:ss")}\n" +
              $"Telefonnummer: {PhoneNumber}\n" +
              $"Samtalets längd (sekunder): {CallDuration}";
        }
    }
    
    

}
