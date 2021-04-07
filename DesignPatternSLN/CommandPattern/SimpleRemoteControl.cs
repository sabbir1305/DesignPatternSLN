using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.CommandPattern
{
    public class SimpleRemoteControl
    {
        ICommand slot;
        public SimpleRemoteControl()
        {

        }
        public void SetCommand(ICommand command)
        {
            slot = command;
        }
        public void ButtonWasPressed()
        {
            slot.Excute();
        }
    }
}
