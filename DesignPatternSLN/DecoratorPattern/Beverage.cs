using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.DecoratorPattern
{
    public abstract class Beverage
    {
        public enum Size
        {
            Tall,
            Grande,
            Venti
        }
        Size size = Size.Tall;
       public string Description = "Unknown Beverage";
        public string GetDescription()
        {
            return this.Description;
        }

        public abstract double Cost();
        public Size GetSize()
        {
            return this.size;
        }
        public void SetSize(Size size)
        {
            this.size = size;
        }
    }
}
