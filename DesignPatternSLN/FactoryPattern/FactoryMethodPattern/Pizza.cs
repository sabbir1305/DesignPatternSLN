using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.FactoryPattern.FactoryMethodPattern
{
    public abstract class Pizza
    {
      public  string name;
      public  string dough;
       public string sauce;
       public List<string> toppings = new List<string>();
      public  string Prepare()
        {
            string process="";

            process += "Preparing " + name;
            process += "Tossing dough...";
            process += "Adding sauce";
            process += "Adding toppings: ";
            foreach (var topping in toppings)
            {
                process += topping + ", ";
            }

            return process;
        }

      public  string Bake()
        {
            return "Bake for 25 minutes";
        }
       public string Cut()
        {
            return "Cut Equal 8 pieces";
        }
       public string Box()
        {
            return "Place pizza in official PizzaStore Box";
        }

        public string GetName()
        {
            return name;
        }

    }
}
