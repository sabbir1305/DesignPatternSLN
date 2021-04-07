using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.CommandPattern
{
    public class CommandController : Controller
    {
        public IActionResult Index()
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            ILight light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);
            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            return View();
        }
    }
}
