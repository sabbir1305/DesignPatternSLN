using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.DecoratorPattern
{
    public class ViewCoffeListDto
    {
        public List<string> CoffeList { get; set; }
        public ViewCoffeListDto()
        {
            CoffeList = new List<string>();
        }
    }
}
