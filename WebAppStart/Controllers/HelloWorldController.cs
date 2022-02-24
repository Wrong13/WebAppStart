using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebAppStart.Controllers
{
    public class HelloWorldController : Controller
    {
        // HelloWorld/
       public string Index()
        {
            return "Это стоковое действие";
        }

        // HelloWorld/Welcome
        public string Welcome(string name,int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
