using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.FactoryPattern
{
    public abstract class PizzaStore
    {
     

        public IPizza OrderPizza(string type)
        {
            IPizza pizza;
            pizza = CreatePizza(type);
            pizza.Bake();
            pizza.Prepare();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
     public  abstract IPizza CreatePizza(string type);
    }
}
