using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM
{
    //    Skapa en klass som hanterar information om en mobiltelefon:
 //modell, tillverkare, pris, ägare, batteriegenskaper(modell,
 //samtalstid och vilotid) samt bildskärmsegenskaper(storlek, antal
 //färger). Skapa 3 separata klasser(klass GSM innehåller instanser
 //av klasserna Battery och Display)
    public class Display
    {
        public int DisplaySize {  get; set; }
        public int DisplayNumbersOfColour {  get; set; }

        public Display(int size, int displayNumbersOfColour)
        {
            DisplaySize = size;
            DisplayNumbersOfColour = displayNumbersOfColour;
        }
       

    }
}
