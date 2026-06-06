using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class AirConditioner : Appliance
    {
        public int Temperature { get; set; }

        public AirConditioner(string brand, string room, int temperature)
            : base(brand, room)
        {
            Temperature = temperature;
        }
        public override string GetInfo()
        {
            return Brand + " air conditioner in " + Room;
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine(Brand + " air conditioner starts cooling.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine(Brand + " air conditioner stops cooling.");
        }

        public override double GetDailyEnergyUsage()
        {
            return 4.2;
        }
    }
}


