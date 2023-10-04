using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{

    public class GSM
    {
        // En egenskap som hanterar samtalshistoriken i en lista
        public List<Call> CallHistory { get; set; }

        // Egenskaper för GSM-enhetens information
        public string Modell {  get; set; }
        public string Manufacture {  get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        public Battery Phonebattery  { get; set; }
        public Display PhoneDisplay { get; set; }
        
        // konstruktor som tar emot all info
        public GSM(string model , string manufacture, decimal price, string owner,Battery battery, Display display  ) 
        {
            Modell = model;
            Manufacture = manufacture;
            Price = price;
            Owner = owner;
            Phonebattery = battery;
            PhoneDisplay = display;

            // skapar en tom lista vid start
            CallHistory = new List<Call>();
        }

        // Konstruktor som tar emot modell och tillverkare, sätter dom andra till null
        public GSM(string model, string manufacture)
            :this(model, manufacture, 0, null, null, null)
        {

        }
        // En metod som returnerar information om GSM-enheten som en textsträng
        public string GetInfo()
        {
            // Skapar en sträng som innehåller information om GSM-enheten
           
            string fullInfo = $"Modell {Modell}\n";
            fullInfo += $"Dom som tillverkat mobilen är  {Manufacture}\n";
            fullInfo += $"Priset är {Price} \n";
            fullInfo += $"Ägaren av mobilen är {Owner ?? "Datan inte tillgänglig"}\n";
            fullInfo += $"Batteriet i telefonen är av typen : {Phonebattery.Type}\n";
            fullInfo += $"Batteriet i telefonen har tillverkaren : {Phonebattery.BatteryModel ?? null} om värdet är noll är datan inte tillgänglig\n";
            fullInfo += $"Samtals tiden för telefonen är :{Phonebattery?.BatteryCallLife ?? 0} om värdet är noll är datan inte tillgänglig\n";
            fullInfo += $"Vilotiden för telefonen är :{Phonebattery?.BatteryStandbyTime ?? 0} om värdet är noll är datan inte tillgänglig\n";
            fullInfo += $"Storleken för displayen är {PhoneDisplay?.DisplaySize ?? 0} om värdet är noll är datan inte tillgänglig\n";
            fullInfo += $"Antal färger är : {PhoneDisplay?.DisplayNumbersOfColour ?? 0 } om värdet är noll är datan inte tillgänglig\n";
            return fullInfo;
        }
        
        // Överskrid ToString-metoden för att använda GetInfo-metoden
        public override string ToString()
        {
            return GetInfo();
        }

        // Metod för att lägga till ett samtal i samtalshistoriken
        public void AddCall(Call call)
        {
            CallHistory.Add( call );
        }
        // Metod för att ta bort ett samtal från samtalshistoriken
        public void RemoveCall(Call call)
        {
            CallHistory.Remove( call );
        }
        // Metod för att rensa hela samtalshistoriken
        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        // Metod som beräknar kostnaden för samtalen baserat på pris per minut
        public decimal CalculateCost (decimal pricePerMinute)
        {
            decimal totalCost = 0;
            // Omvandla samtalets längd från sekunder till minuter
            foreach (Call call in CallHistory)
            {
                decimal callDurationInMinutes = (decimal)call.CallDuration / 60;
                // Lägg till kostnaden för samtalet baserat på pris per minut
                totalCost += (int)(callDurationInMinutes * pricePerMinute);
            }

            return totalCost;
        }



        // En statisk instans av en iPhone 10-enhet
        private static GSM iPhone10;

        // En egenskap som ger åtkomst till iPhone 10-instansen
        public static GSM Iphone10
        {
            get
        {
            if (iPhone10 == null)
            {
                    Battery battery1 = new Battery("BatteriExperten", 23, 21, type: BatteryType.Lijon);
                    Display display1 = new Display(23, 14);
                    // Skapa en instans av iPhone 10 om den inte redan finns
                    iPhone10 = new GSM("iPhone 10", "Apple", 999.99m, "Anton", battery1, display1);
            }
            return iPhone10;
        }
    }
        }

   


    
}
