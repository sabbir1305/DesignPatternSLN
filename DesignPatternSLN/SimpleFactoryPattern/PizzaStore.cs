using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.FactoryPattern
{
    public class PizzaStore
    {
        SimplePizzaFactory factory;
        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public IPizza OrderPizza(string type)
        {
            IPizza pizza;
            pizza = factory.CreatePizza(type);
            pizza.Bake();
            pizza.Prepare();
            pizza.Cut();
            return pizza;
        }
    }
}
