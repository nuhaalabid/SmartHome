using SmartHome;
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<object> devices = new List<object>();
        // TODO:
        // Skapa minst fyra objekt:
        // Washer, Refrigerator, Oven och RobotVacuum.
        // Lägg till dem i listan devices.
        Washer washer = new Washer();
        washer.Brand = "LG";
        washer.CapacityKg = 8;

        Refrigerator refrigerator = new Refrigerator();
        refrigerator.Brand = "Samsung";
        refrigerator.Temperature = 4;

        Oven oven = new Oven();
        oven.Brand = "Electrolux";
        oven.MaxTemperature = 250;

        RobotVacuum robotVacuum = new RobotVacuum();
        robotVacuum.Brand = "Xiaomi";
        robotVacuum.BatteryLevel = 150;

        CoffeeMachine coffeeMachine = new CoffeeMachine();
        coffeeMachine.Brand = "Nespresso";
        coffeeMachine.CupsPerBrew = 2;


        devices.Add(washer);
        devices.Add(refrigerator);
        devices.Add(oven);
        devices.Add(robotVacuum);
        devices.Add(coffeeMachine);

        RunMorningRoutine(devices);
        Console.WriteLine();
        ReportAllEnergy(devices);
    }
    static void RunMorningRoutine(List<object> devices)
    {
        foreach (object device in devices)
        {
            // TODO:
            // 1. Kontrollera vilken typ device är.
            // 2. Casta till rätt typ.
            // 3. Anropa rätt startmetod.
            // 4. Anropa rätt stoppmetod.

                if (device is Washer washer)
                {
                    washer.StartWash();
                    washer.StopWash();
                }
                else if (device is Refrigerator refrigerator)
                {
                    refrigerator.StartCooling();
                    refrigerator.StopCooling();
                }
                else if (device is Oven oven)
                {
                    oven.StartHeating();
                    oven.StopHeating();
                }
                else if (device is RobotVacuum robotVacuum)
                {
                    robotVacuum.StartCleaning();
                    robotVacuum.StopCleaning();
                }
               else if (device is CoffeeMachine coffeeMachine)
               {
                coffeeMachine.StartBrewing();
                coffeeMachine.StopBrewing();
               }
        }
        }
    
    static void ReportAllEnergy(List<object> devices)
    {
        foreach (object device in devices)
        {
            // TODO:
            // 1. Kontrollera vilken typ device är.
            // 2. Casta till rätt typ.
            // 3. Anropa rätt energimetod.
           
                if (device is Washer washer)
                {
                    washer.PrintWashEnergy();
                }
                else if (device is Refrigerator refrigerator)
                {
                    refrigerator.PrintCoolingEnergy();
                }
                else if (device is Oven oven)
                {
                    oven.PrintHeatingEnergy();
                }
                else if (device is RobotVacuum robotVacuum)
                {
                    robotVacuum.PrintCleaningEnergy();
                }
                else if (device is CoffeeMachine coffeeMachine)
                {
                coffeeMachine.PrintBrewingEnergy();
                }
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

