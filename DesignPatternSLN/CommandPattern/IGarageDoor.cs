using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.CommandPattern
{
  public  interface IGarageDoor
    {
        string Up();
        string Down();
        string Stop();
        string LightOn();
        string LightOff();
    }
}
