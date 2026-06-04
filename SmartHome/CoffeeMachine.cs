using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class CoffeeMachine
    {
        public string Brand { get; set; }
        public int CupsPerBrew { get; set; }

        public void StartBrewing()
        {
            Console.WriteLine(Brand + " coffee machine starts brewing.");
        }

        public void StopBrewing()
        {
            Console.WriteLine(Brand + " coffee machine stops brewing.");
        }

        public void PrintBrewingEnergy()
        {
            Console.WriteLine(Brand + " coffee machine uses 0.8 kWh per brew.");
        }
    }
}

// Del 2
// När jag lade till CoffeeMachine behövde jag ändra tre ställen i koden:
// Main(), RunMorningRoutine() och ReportAllEnergy().