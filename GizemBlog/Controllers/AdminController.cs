using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace GizemBlog.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AdminNavbarPartial()
        {
            return PartialView();
        }
    }
}
