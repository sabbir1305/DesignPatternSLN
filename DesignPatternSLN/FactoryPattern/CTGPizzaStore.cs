using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.FactoryPattern
{
    public class CTGPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {

            }
            else if (type.Equals("clam"))
            {

            }

            return null;
        }
    }
}
