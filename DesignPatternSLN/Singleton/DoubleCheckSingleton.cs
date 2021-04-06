using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.Singleton
{
    public sealed class DoubleCheckSingleton
    {
         DoubleCheckSingleton()
        {

        }
        private static readonly object padlock = new object();
        private static DoubleCheckSingleton instance = null;
        public static DoubleCheckSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new DoubleCheckSingleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
