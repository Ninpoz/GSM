using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    public class GSMTest
    {
        public void RunTests()
        {
            

            Battery battery1 = new Battery("apa", 23, 21, type: BatteryType.Lijon);
            Display display1 = new Display(23, 14);

            Battery battery2 = new Battery("hund", 51,123, type: BatteryType.NiMH);
            Display display2 = new Display( 6132, 2156);

            Battery battery3 = new Battery("lol", 643, 1265,type: BatteryType.NiCd);
            Display display3 = new Display( 21578, 1254);
            
            GSM[] Phone = new GSM[3];
            Phone[0] = new GSM ("model1", "Manufacture 1", 20000, "owner 1",  battery1 , display1);
            Phone[1] = new GSM ("model2", "Manufacture 2", 23150, "owner2", battery2 , display2);
            Phone[2] = new GSM("model3", "manufacture3", 5312, "owner3", battery3, display3);
           

            Console.WriteLine("informationen visas i arrayen");
            foreach (GSM phone in Phone)
            {
                Console.WriteLine(phone.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("Info om iphone10");
            Console.WriteLine(GSM.Iphone10);

        }
        
    }
}
