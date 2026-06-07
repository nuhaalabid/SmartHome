using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class SmartLamp : Appliance
    {
        public int Brightness { get; set; }
        public SmartLamp(string brand, string room, int brightness)
        : base(brand, room)
        {
            // TODO:
            // Spara brightness.
            Brightness = brightness;
        }
        public new void TurnOn()
        {
            // TODO:
            // Skriv ut att lampan tänds.
            Console.WriteLine(Brand + " smart lamp turns on.");
        }
    }


}

