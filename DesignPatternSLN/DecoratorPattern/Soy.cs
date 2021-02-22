using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.DecoratorPattern
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
           return beverage.Cost() + .15;
        }

        public override string GetDescrption()
        {
            return beverage.Description+", Soy";
        }
    }
}
