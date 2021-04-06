using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.FactoryPattern.FactoryMethodPattern
{
    public class DependentPizzaStore
    {
        public Pizza CreatePizza(string style , string type)
        {
            Pizza pizza = null;
            if (style.Equals("NY"))
            {
                if (type.Equals("cheese"))
                {
                    pizza = new NYStyleCheesePizza();
                }
                else if (type.Equals("veggie"))
                {
                    //other not created
                    pizza = new NYStyleCheesePizza();
                }
            }
            else if (style.Equals("chich"))
            {
                if (type.Equals("cheese"))
                {
                    pizza = new ChicagoStyleCheesePizza();
                }
            }
            else
            {
                return null;
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
