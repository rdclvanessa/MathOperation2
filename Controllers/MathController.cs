using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MathOperation2.Models; 

using MathLibrary;

namespace MathOperation2.Controllers
{
    public class MathController : Controller
    {
        [HttpGet]
        public IActionResult DoCalculation()
        {
            ConverterViewModel model = new ConverterViewModel();
            return View(model);
        }  
        [HttpPost]
       public IActionResult ShowCalculationResult(ConverterViewModel model)
        {
            //the conversion work happens in here
            model.Result = model.LeftOperand * model.RightOperand;
            return View(model);
        }   
    }
}
