using SmartHome;
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        SmartHomeController controller = new SmartHomeController();

        // TODO:
        controller.AddDevice(new Washer("LG", "Laundry Room", 8));
        controller.AddDevice(new Refrigerator("Samsung", "Kitchen", 4));
        controller.AddDevice(new Oven("Electrolux", "Kitchen", 250));
        controller.AddDevice(new RobotVacuum("Xiaomi", "Living Room", 100));
        controller.AddDevice(new CoffeeMachine("Nespresso", "Kitchen", 2));
        controller.AddDevice(new AirConditioner("Daikin", "Bedroom", 22));

        controller.ScheduleAllSchedulableDevices(DateTime.Now.AddHours(2));

        SmartLamp lamp1 = new SmartLamp("IKEA", "Hallway", 80);

        Appliance lamp2 = lamp1;

        lamp1.TurnOn();
        lamp2.TurnOn();

        Console.WriteLine();

        controller.PrintStatusReport();
        Console.WriteLine();

        controller.TurnOnAll();
        Console.WriteLine();

        double totalEnergy = controller.GetTotalDailyEnergyUsage();

        Console.WriteLine("Total daily energy usage: " + totalEnergy + " kWh");

        Console.WriteLine();

        controller.TurnOffAll();
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


// Frågor efter Del 9

// 1. Varför kan vi inte anropa Schedule() direkt på en variabel av typen Appliance?
// Appliance har ingen metod som heter Schedule().

// 2. Varför fungerar det efter att vi castar till ISchedulable?
// Efter casting får vi tillgång till metoderna i ISchedulable, inklusive Schedule().

// 3. Vad betyder det att RobotVacuum både är en Appliance och en ISchedulable?
// RobotVacuum är en apparat och kan samtidigt schemaläggas.

// 4. Varför ska inte Schedule() ligga direkt i Appliance?
// Alla apparater kan inte schemaläggas, till exempel Refrigerator och Oven.

// 5. Vad är skillnaden mellan arv och interface i det här exemplet?
// Arv beskriver vad objektet är Appliance.
// Interface beskriver vad objektet kan göra ISchedulable.


//Del 10 test A:
// Kompilatorn ger fel eftersom TurnOn() i Appliance inte längre är virtual.
// En metod måste vara virtual,abstract eller override för att kunna override i child classes.

// Test B:
// Jag fick en varning när jag tog bort override.
// C# föreslog att använda new eftersom metoden döljer basklassens metod.


// Del 11

// 1. Blir utskriften samma?
// Nej, utskriften blir olika.

// 2. Vilken metod körs när variabeln har typen SmartLamp?
// SmartLamp.TurnOn() körs.

// 3. Vilken metod körs när variabeln har typen Appliance?
// Appliance.TurnOn() körs.

// 4. Varför är detta farligt eller förvirrande?
// Samma objekt kan köra olika metoder beroende på variabelns typ.

// 5. Vad händer om du byter new till override?
//  körs SmartLamp.TurnOn() även när variabeln har typen Appliance.

// new döljer metoden från basklassen.
// override gör att den nya metoden används istället för basklassens metod.


// Del 12

// 1. Vad säger kompilatorn?
// Kompilatorn säger att TurnOn() inte kan override:a eftersom den är sealed.

// 2. Varför får PizzaOven inte override:a TurnOn()?
// Sealed stoppar child classes från att override:a metoden igen.

// 3. När kan det vara rimligt att använda sealed override?
// När man vill låsa ett beteende så att det inte ändras längre.

// 4. Vad kan PizzaOven fortfarande göra i stället?
// Den kan använda TurnOn() från Oven och override:a andra metoder som inte är sealed.