using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSLN.CommandPattern.RemoteExample
{
    public class RemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();

            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void setCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;

        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].Excute();
        }
        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].Excute();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("---Remote Control---");
            builder.Append("\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                builder.Append("[slot " + i + "] " + onCommands[i].GetType().Name + " " + offCommands[i].GetType().Name);
                builder.Append("\n");
            }
            return builder.ToString();
        }
    }
}
