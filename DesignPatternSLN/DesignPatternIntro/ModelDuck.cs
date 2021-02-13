using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.DesignPatternIntro
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehaviour = new FlyRocketPowered();
            quackBehaviour = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I m a duck");
        }
    }
}
