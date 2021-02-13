using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.DesignPatternIntro
{
    public interface IFlyBehaviour
    {
        string Fly();
    }
    public class FlyingWithWings : IFlyBehaviour
    {
        public string Fly()
        {
            return "Two wings takes you to the moon.";
        }
    }

    public class FlyNoWay : IFlyBehaviour
    {
        public string Fly()
        {
            return "I don't want to fly it is boring, not that i can't!";
        }
    }
    public class FlyRocketPowered : IFlyBehaviour
    {
        public string Fly()
        {
            return "wow a rocket on my back!";
        }
    }
}
