using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.FactoryPattern.FactoryMethodPattern
{
    public class NYStyleCheesePizza:Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
