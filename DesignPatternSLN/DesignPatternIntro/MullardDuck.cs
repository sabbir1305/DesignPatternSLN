using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.DesignPatternIntro
{
    public class MullardDuck : Duck
    {
        public MullardDuck()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyingWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("Beautiful duck , i guess it tastes good!");
        }
    }
}
