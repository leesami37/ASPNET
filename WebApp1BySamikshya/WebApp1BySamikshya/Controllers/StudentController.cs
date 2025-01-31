﻿using Microsoft.AspNetCore.Mvc;
using WebApp1BySamikshya.Models;

namespace WebApp1BySamikshya.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateStudentRecord()
        {
            ViewData["SuccessMessage"] = "null";
            return View();
        }
        [HttpPost]
        public IActionResult CreateStudentRecord(Student s1)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ViewData["SuccessMessage"] = "Success";
                    return View("Details", s1);
                }
                else return View();
                //return RedirectToAction(nameof(Details));
            }
            catch(Exception ex)
            {
                return Content("Something went wrong when creating student record: " + ex.Message);
            }
        }
    }
}
