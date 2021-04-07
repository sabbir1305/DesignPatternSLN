using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.CommandPattern
{
   public interface ILight
    {
        string On();
        string Off();
    }
}
