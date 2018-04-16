using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Form()
      {
        return View();
      }

      // [Route("/form")]
      // public ActionResult Form()
      // {
      //   return View();
      // }

      [Route("/greeting_card")]
       public ActionResult GreetingCard()
       {
           ParcelVariable myParcelVariable = new ParcelVariable();
           myParcelVariable.SetLength(Request.Query["length"]);
           myParcelVariable.SetWidth(Request.Query["width"]);
           myParcelVariable.SetHeight(Request.Query["height"]);
           myParcelVariable.SetWeight(Request.Query["weight"]);
           //myLetterVariable.SetSender(Request.Query["sender"]);
           return View("Hello", myParcelVariable);
       }
    }
}
