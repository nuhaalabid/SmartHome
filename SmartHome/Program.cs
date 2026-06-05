using SmartHome;
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<Appliance> devices = new List<Appliance>();
        // TODO:
        devices.Add(new Washer("LG", "Laundry Room", 8));
        devices.Add(new Refrigerator("Samsung", "Kitchen", 4));
        devices.Add(new Oven("Electrolux", "Kitchen", 250));
        devices.Add(new RobotVacuum("Xiaomi", "Living Room", 100));
        devices.Add(new CoffeeMachine("Nespresso", "Kitchen", 2));

        foreach (Appliance device in devices)
        {
            // Skriv ut info.
            // Starta apparaten.
            // Skriv ut energiförbrukning.
            // Stäng av apparaten.

            Console.WriteLine("INFO:" + device.GetInfo());

            device.TurnOn();

            Console.WriteLine("Daily energy usage: " + device.GetDailyEnergyUsage() + " kWh");

            device.TurnOff();

            Console.WriteLine();
        }

    }
    }


//Reflektionsfrågor efter Del 1

//Svara som kommentarer längst ner i din kod.
//1. Varför behövde du kontrollera vilken typ varje objekt hade?
//Eftersom listan är List<object> och programmet vet inte vilken apparat varje objekt är.

//2.Vad händer om du lägger till en ny klass CoffeeMachine?
// Jag måste lägga till ny kod för att hantera CoffeeMachine.

//3. Vilka metoder måste du ändra om du lägger till CoffeeMachine?
//Jag måste ändra Main(), RunMorningRoutine() och ReportAllEnergy().

//4. Vad är problemet med att listan är List<object>?
// Jag måste använda typkontroll och casting för att komma åt metoderna.

//5. Vad händer om du råkar glömma en apparattyp i ReportAllEnergy()?
//Då skrivs inte energiförbrukningen ut för den apparaten.



// Frågor efter Del 5

// 1.Varför fungerar device.TurnOn() trots att device har typen Appliance?
// Eftersom TurnOn() är virtual i Appliance och override i child classes.
// Polymorfism gör att rätt metod körs automatiskt.

// 2. Vilken metod körs om objektet egentligen är en RobotVacuum?
// RobotVacuums override av TurnOn() körs.

// 3. Vad blev bättre jämfört med List<object>?
// Vi behöver inte använda if, is eller casting.
// Samma kod fungerar för alla apparater.