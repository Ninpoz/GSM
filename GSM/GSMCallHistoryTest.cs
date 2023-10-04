using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
//   • Skapa en instans av GSM
//• Lägg till några samtal
//• Visa information om samtalen
//• Antag att priset per minut är 0,37 kronor.Beräkna totalpriset för samtalen i
//historiken
//• Ta bort det längsta samtalet från historiken och räkna ut priset på nytt
//• Slutligen, skriv ut och rensa samtalshistoriken
    public class GSMCallHistoryTest
    {
        public static void RunTest()
        {
            // Hårdkodar in all info som GSM klassen behöver
            GSM myGSM = new GSM("Iphone", "Apple", 13249, "Anton", new Battery("model x", 200, 10, BatteryType.Lijon), new Display(6, 20000));
            //gör en ny string för att sen kalla på GetInfo klassen och matar in den datan där
            string gsmInfo = myGSM.GetInfo();
            //Printar ut den nya infon
            Console.WriteLine(gsmInfo);
            //Lägger till 3 samtal i historiken, hårdkodat
            myGSM.AddCall(new Call(DateTime.Now.AddDays(-6), TimeSpan.FromMinutes(10),"123-456-12",20));
            myGSM.AddCall(new Call(DateTime.Now.AddDays(-2), TimeSpan.FromMinutes(20), "123-642-12", 12));
            myGSM.AddCall(new Call(DateTime.Now.AddDays(-1), TimeSpan.FromMinutes(40), "123-123-12", 7));

            Console.WriteLine("Samtalslista:");
            foreach (Call call in myGSM.CallHistory)
            {
                Console.WriteLine(call.GetCallInfo());
            }

            //Beräkna priset om per minut kostar 0.37kr
            decimal pricePerMinut = 0.37m;
            decimal totalCost = myGSM.CalculateCost(pricePerMinut);
            Console.WriteLine(totalCost);
            
        }
       
            //metod för att visa samtalshistoriken
        public static void DisplayCallHistory(List<Call> callHistory)
        {
            foreach (Call call in callHistory)
            {
                Console.WriteLine(call.GetCallInfo());
            }
        }
        
        //metod för att hitta det längsta samtalet i historiken
        public static Call FindLongestCall(List<Call> callHistory)
        {
            if (callHistory.Count == 0)
            {
                return null;
            }

            Call longestCall = callHistory[0];
            foreach (Call call in callHistory)
            {
                if (call.CallDuration > longestCall.CallDuration) 
                {
                    longestCall = call;
                }
            }

            return longestCall;

        }


        
    }


}
