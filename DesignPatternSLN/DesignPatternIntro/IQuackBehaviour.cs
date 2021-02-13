using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.DesignPatternIntro
{

    public interface IQuackBehaviour
    {
        string Quack();
    }

    public class Quack : IQuackBehaviour
    {
        string IQuackBehaviour.Quack()
        {
            return "Quack!";
        }
    }

    public class MuteQuack : IQuackBehaviour
    {
        string IQuackBehaviour.Quack()
        {
            return "<<------>>!";
        }
    }
    public class Squeak : IQuackBehaviour
    {
        string IQuackBehaviour.Quack()
        {
            return "Squeak!!!";
        }
    }
}
