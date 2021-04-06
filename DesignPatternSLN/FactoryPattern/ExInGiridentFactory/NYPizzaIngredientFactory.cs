using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.FactoryPattern.ExInGiridentFactory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreatCheese()
        {
            throw new NotImplementedException();
        }

        public IClams CreateClam()
        {
            throw new NotImplementedException();
        }

        public IDough CreateDough()
        {
           return new ThinCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            throw new NotImplementedException();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public IViggies[] CreatVeggies()
        {
            throw new NotImplementedException();
        }
    }
}
