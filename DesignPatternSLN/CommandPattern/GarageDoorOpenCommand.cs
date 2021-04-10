using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.CommandPattern
{
    public class GarageDoorOpenCommand : ICommand
    {
        private IGarageDoor _garageDoor;

        public GarageDoorOpenCommand(IGarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Excute()
        {
            _garageDoor.Up();
        }
    }
}
