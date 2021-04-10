using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.CommandPattern
{
    public class NoCommand : ICommand
    {
        public void Excute()
        {
            throw new NotImplementedException();
        }
    }
}
