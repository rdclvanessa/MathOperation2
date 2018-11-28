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
        public string Add(decimal LeftOperand, decimal RightOperand)
        {
            //MyMath routines = new MyMath();
            // decimal value = routines.Add(left, right);
            return $"{LeftOperand} plus {RightOperand} is: {MyMath.Add(LeftOperand,RightOperand)}";
        }
        public string Subtract(decimal up, decimal down)
        {
            return $"{up} minus {down} is {Decimal.Subtract(up, down)}";
        }

        public string Mulitply(decimal x, decimal y)
        {
            return $"{x} times {y} is {Decimal.Multiply(x, y)}";
        }

        public string Divide(decimal a, decimal b)
        {
            return $"{a} divided by {b} equals {Decimal.Divide(a, b)}";
        }
    }
}
