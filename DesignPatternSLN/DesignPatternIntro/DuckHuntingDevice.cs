using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.DesignPatternIntro
{
    public class HuntingDevice
    {
        public IQuackBehaviour quackBehaviour;
        public string Quack { get; set; }
        public void SetQuackBehavior(IQuackBehaviour quack)
        {
            this.quackBehaviour = quack;
        }
        public void PerformQuack()
        {
            Quack = quackBehaviour.Quack();
        }
    }
    public class DuckHuntingDevice : HuntingDevice
    {
        public DuckHuntingDevice()
        {
            quackBehaviour = new Quack();
        }
    }
}
