using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Hello()
      {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.SetRecipient("Jessica");
        return View(myLetterVariable);
      }

      [Route("/form")]
      public ActionResult Form()
      {
        return View();
      }

      [Route("/greeting_card")]
       public ActionResult GreetingCard()
       {
           LetterVariable myLetterVariable = new LetterVariable();
           myLetterVariable.SetRecipient(Request.Query["recipient"]);
           myLetterVariable.SetSender(Request.Query["sender"]);
           return View("Hello", myLetterVariable);
       }
    }
}
