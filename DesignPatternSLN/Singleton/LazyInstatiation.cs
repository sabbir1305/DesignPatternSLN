using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.Singleton
{
    public sealed class LazyInstatiation
    {
        private static readonly LazyInstatiation instance = new LazyInstatiation();
        static LazyInstatiation() { }
        private LazyInstatiation(){ }

        public static LazyInstatiation Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
