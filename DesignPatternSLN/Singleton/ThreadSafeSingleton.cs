using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.Singleton
{
    //Bad Performance as lock required every time it is called
    public sealed class ThreadSafeSingleton
    {
         ThreadSafeSingleton()
        {

        }
        private static readonly object padLock = new object();
        private static ThreadSafeSingleton instance = null;
        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (padLock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                    return instance;
                }
            }
        }
    }
}
