using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome
{
    public class PizzaOven :Oven
    {
            public PizzaOven(string brand, string room, int maxTemperature)
            : base(brand, room, maxTemperature)
            {
            }

           // Tog bort override:a Turrn0n() eftersom metoden är sealed i Oven.
        
        }


    }

