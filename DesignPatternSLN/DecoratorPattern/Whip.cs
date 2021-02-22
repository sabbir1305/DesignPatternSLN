using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.DecoratorPattern
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
          return beverage.Cost()+.36;
        }

        public override string GetDescrption()
        {
          return beverage.GetDescription() + " , Whip";
        }
    }
}
