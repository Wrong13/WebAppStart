using Microsoft.AspNetCore.Mvc;
using WebAppStart.Models;

namespace WebAppStart.Controllers
{
    public class LogInController : Controller
    {
        WebAppStart.Data.WebAppStartContext context;
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateUser(User AddUser)
        {
            if (!ModelState.IsValid)
            {
                context.User.Add(AddUser);
                context.SaveChanges();
            }
            return View(Index());
        }

    }
}
