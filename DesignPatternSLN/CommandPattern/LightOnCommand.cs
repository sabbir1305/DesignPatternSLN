using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.CommandPattern
{
    public class LightOnCommand : ICommand
    {
      private readonly ILight _light;
        public LightOnCommand(ILight light)
        {
            _light = light;
        }
        public void Excute()
        {
            _light.On();
        }
    }
}
