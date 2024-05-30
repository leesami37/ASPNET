﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp6BySamikshya.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult Index()
        {
            TempData["myMessage"] = "Greetings, This is temp data message.";
            return View();
        }
        public IActionResult TempDataPage()
        {
            return View();
        }
    }
}
