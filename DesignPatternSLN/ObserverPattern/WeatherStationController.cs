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
            data.SetMEasurements(10, 20, 30);
            CurrentConditionDisplay currentCondition = new CurrentConditionDisplay(data);
            currentCondition.Update();
            currentCondition.Display();
            return View(currentCondition);
        }
    }
}
