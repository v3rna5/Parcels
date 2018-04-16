using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {


      [Route("/")]
      public ActionResult Form()
      {
        return View();
      }

      [Route("/onSubmit")]
       public ActionResult OnSubmit()
       {
          string length=Request.Query["length"];
          string width=Request.Query["width"];
          string height=Request.Query["height"];
          string weight=Request.Query["weight"];

          int num2;
          bool validLength=int.TryParse(length, out num2);
          bool validWidth=int.TryParse(width, out num2);
          bool validHeight=int.TryParse(height, out num2);
          bool validWeight=int.TryParse(weight, out num2);
          if (validLength==true && validWidth==true && validHeight==true && validWeight==true)
          {
            ParcelVariable myParcelVariable = new ParcelVariable();
            myParcelVariable.SetLength(Request.Query["length"]);
            myParcelVariable.SetWidth(Request.Query["width"]);
            myParcelVariable.SetHeight(Request.Query["height"]);
            myParcelVariable.SetWeight(Request.Query["weight"]);
            return View("Hello", myParcelVariable);
          }
          else {
            Console.WriteLine("SORRY THIS DOESNT WORK");
            return View("Form");
          }
       }
    }
}
