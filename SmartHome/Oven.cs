using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class Oven :Appliance
    {
       
        public int MaxTemperature { get; set; }

        public Oven(string brand, string room, int maxTemperature)
         : base(brand, room)
        {
            MaxTemperature = maxTemperature;
        }

        public override string GetInfo()
        {
            return Brand + " oven in " + Room;
        }

        public sealed override void TurnOn()
        {
            //sealed gör att child classes inte kan override:a TurnOn() igen.
            IsOn = true;
            Console.WriteLine(Brand + " oven starts preheating.");
        }
      
        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine(Brand + " oven stops heating.");
        }

        public override double GetDailyEnergyUsage()
        {
            return 2.5;
        }
    }

}

    
