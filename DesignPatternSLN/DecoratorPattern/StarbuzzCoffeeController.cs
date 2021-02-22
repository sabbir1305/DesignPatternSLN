using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSLN.DecoratorPattern
{
    public class StarbuzzCoffeeController : Controller
    {
        public IActionResult Index()
        {

            ViewCoffeListDto listDto = new ViewCoffeListDto();
            Beverage beverage = new Espresso();
            listDto.CoffeList.Add (beverage.GetDescription() + " $" + beverage.Cost());
        

            Beverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1,Beverage.Size.Tall);
            beverage1 = new Whip(beverage1);
       
            beverage1 = new Soy(beverage1);
            listDto.CoffeList.Add(beverage1.GetDescription() + " $" + beverage1.Cost());


            return View(listDto);
        }
    }
}
