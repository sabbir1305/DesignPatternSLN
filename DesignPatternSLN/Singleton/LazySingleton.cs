using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.Singleton
{
    public sealed class LazySingleton
    {
        private LazySingleton()
        {

        }
        private static readonly Lazy<LazySingleton> lazy = new Lazy<LazySingleton>(() => new LazySingleton());
        public static LazySingleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
