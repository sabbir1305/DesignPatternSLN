using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
      public  Beverage beverage;

        public abstract string GetDescrption();
      
       
    }
}
