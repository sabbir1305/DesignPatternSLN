using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.ObserverPattern
{
    public class WeatherStationController : Controller
    {
        public IActionResult Index()
        {
            var data = new WeatherData();
           
            CurrentConditionDisplay currentCondition = new CurrentConditionDisplay(data);
            currentCondition.Update(30, 10, 0);
            currentCondition.Display();
            return View(currentCondition);
        }
    }
}
