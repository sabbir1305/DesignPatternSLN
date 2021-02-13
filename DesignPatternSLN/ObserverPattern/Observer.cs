using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.ObserverPattern
{
    public interface IObserver
    {
        void Update(double temp, double humidity, double pressure);
    }

}
