using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{//    Skapa en klass som hanterar information om en mobiltelefon:
 //modell, tillverkare, pris, ägare, batteriegenskaper(modell,
 //samtalstid och vilotid) samt bildskärmsegenskaper(storlek, antal
 //färger). Skapa 3 separata klasser(klass GSM innehåller instanser
 //av klasserna Battery och Display)
    public class Battery
    {
       
        public string BatteryModel { get; set; }
        public double BatteryCallLife {  get; set; }
        public double BatteryStandbyTime {  get; set; }
        public BatteryType Type { get; set; }

        public Battery (string model, double callLife, double standbyTime,BatteryType type ) 
        { 
            BatteryModel = model;
            BatteryCallLife = callLife;
            BatteryStandbyTime = standbyTime;
            Type = type;
        }

    }
}
