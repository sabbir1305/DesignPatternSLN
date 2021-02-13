using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.DesignPatternIntro
{
    public abstract class Duck
    {
      public  IFlyBehaviour flyBehaviour;
      public  IQuackBehaviour quackBehaviour;
        public string Fly { get; set; }
        public string Quack { get; set; }

        public Duck()
        {

        }
        public abstract void Display();

        public void PerformFly()
        {
            Fly= flyBehaviour.Fly();
        }
        public void PerformQuack()
        {
           Quack= quackBehaviour.Quack();
        }
        public string Swim()
        {
            return $"All ducks float, even decos ! so ths moron named {nameof(Duck)} also swims";
        }
        public void SetFlyBehavior(IFlyBehaviour flyBehaviour)
        {
            this.flyBehaviour = flyBehaviour;
        }
        public void SetQuackBehavior(IQuackBehaviour quack)
        {
            this.quackBehaviour = quack;
        }
    }

    


   



}
