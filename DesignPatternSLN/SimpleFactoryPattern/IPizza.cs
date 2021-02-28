using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.FactoryPattern
{
  public  interface IPizza
    {
        void Prepare();
        void Bake();
        void Cut();

        void Box();
    }

}
