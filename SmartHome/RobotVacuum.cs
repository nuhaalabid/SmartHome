using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class RobotVacuum :Appliance
    {
     
        public int BatteryLevel { get; set; }

        public RobotVacuum(string brand, string room, int batteryLevel)
             : base(brand, room)
        {
            BatteryLevel = batteryLevel;
        }

        public override string GetInfo()
        {
            return Brand + " robot vacuum in " + Room;
        }

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine(Brand + " robot vacuum starts cleaning.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine(Brand + " robot vacuum stops cleaning.");
        }

        public override double GetDailyEnergyUsage()
        {
            return 0.4;
        }
    }
}
    

