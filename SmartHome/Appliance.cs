using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class Appliance
    {
        public string Brand { get; }
        public string Room { get; }
        public bool IsOn { get; protected set; }
        public Appliance(string brand, string room)
        {
            // TODO:
            Brand = brand;
            Room = room;
            IsOn = false;  
        }
        public virtual string GetInfo()
        {
            // TODO:
            // Returnera en generell text om apparaten.
            // Exempel: "LG in Laundry room"
            return Brand + " in " + Room;
        }
        public virtual void TurnOn()
        {
            // TODO:
            // Sätt IsOn till true.
            // Skriv ut ett generellt startmeddelande.
            IsOn = true;
            Console.WriteLine(Brand + " appliance turns on.");
        }
        public virtual void TurnOff()
        {
            // TODO:
            // Sätt IsOn till false.
            // Skriv ut ett generellt stoppmeddelande.
            IsOn = false;
            Console.WriteLine(Brand + " appliance turns off.");
        }
        public virtual double GetDailyEnergyUsage()
        {
            // TODO:
            // Returnera 0 som standardvärde.
            return 0;
        }
    }
}

