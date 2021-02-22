using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage,Size size)
        {
            this.beverage = beverage;
            this.beverage.SetSize(size);
        }

        public override double Cost()
        {
            double cost = .20;
            if (Size.Tall == this.beverage.GetSize())
            {
                cost = 10 + .20;
            }
           else if (Size.Grande == this.beverage.GetSize())
            {
                cost = 20 + .20;
            }
            else if (Size.Venti == this.beverage.GetSize())
            {
                cost = 30 + .20;
            }
            return beverage.Cost() + cost;
        }

        public override string GetDescrption()
        {
            return beverage.GetDescription() + " , Mocha";
        }


    }
}
