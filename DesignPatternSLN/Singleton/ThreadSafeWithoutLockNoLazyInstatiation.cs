using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.Singleton
{
    public class ThreadSafeWithoutLockNoLazyInstatiation
    {
        private static readonly ThreadSafeWithoutLockNoLazyInstatiation instance = new ThreadSafeWithoutLockNoLazyInstatiation();
        static ThreadSafeWithoutLockNoLazyInstatiation() { }
        private ThreadSafeWithoutLockNoLazyInstatiation() { }
        public static ThreadSafeWithoutLockNoLazyInstatiation Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
