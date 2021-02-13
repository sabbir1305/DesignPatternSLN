using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.DesignPatternIntro
{
    public class MiniDuckSimulatorController : Controller
    {
        public IActionResult Mallard()
        {
            Duck mallard = new MullardDuck();
       
            mallard.PerformFly();
            mallard.PerformQuack();
            mallard.Display();
            return View(mallard);
        }
        public IActionResult ModelDuck()
        {
            Duck duck = new ModelDuck();
            duck.PerformQuack();
            duck.PerformFly();
            duck.SetFlyBehavior(new FlyingWithWings());
            duck.PerformFly();

            return View(duck);
        }

        public IActionResult DuckDevice()
        {
            var dev = new DuckHuntingDevice();
            dev.PerformQuack();

            return View(dev);

        }
    }
}
