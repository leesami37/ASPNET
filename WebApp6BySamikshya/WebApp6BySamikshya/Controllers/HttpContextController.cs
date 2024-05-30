﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp6ByWebApp6BySamikshya.Controllers
{
    public class HttpContextController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Items["MyHttpContextData"] = "This is HttpContext data";
            var httpContextData = HttpContext.Items["MyHttpContextData"];
            ViewBag.myData = httpContextData;
            return View();
        }
    }
}
