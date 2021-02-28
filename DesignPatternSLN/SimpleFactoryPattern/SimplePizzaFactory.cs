using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.FactoryPattern
{
    public class SimplePizzaFactory
    {
        public IPizza CreatePizza(string type)
        {
            IPizza pizza = null;
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }

            return pizza;
        }
    }
}
