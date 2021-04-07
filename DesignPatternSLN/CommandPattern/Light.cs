using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.CommandPattern
{
    public class Light : ILight
    {
        public string Off()
        {
            return "Light off";
        }

        public string On()
        {
            return "Light on";
        }
    }
}
