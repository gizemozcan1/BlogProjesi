﻿using Microsoft.AspNetCore.Mvc;

namespace GizemBlog.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
