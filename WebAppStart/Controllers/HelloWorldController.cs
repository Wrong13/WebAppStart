using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebAppStart.Controllers
{
    public class HelloWorldController : Controller
    {
        // HelloWorld/
       public IActionResult Index()
        {
            return View();
        }

        // HelloWorld/Welcome
        public IActionResult Welcome(string name,int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
