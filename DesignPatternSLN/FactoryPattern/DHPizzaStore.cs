using DesignPatternSLN.SimpleFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.FactoryPattern
{
    public class DHPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new DHCheesePizza();
            }
            else if (type.Equals("clam"))
            {
                return new DHClamPizza();
            }
            return null;
        }
    }
}
