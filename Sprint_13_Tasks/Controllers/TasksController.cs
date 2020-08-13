using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Sprint_13_Tasks.Model;
using Sprint_13_Tasks.Pages.Tasks;

namespace Sprint_13_Tasks.Controller
{
    public class TasksController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IProduct _product;

        public TasksController(IProduct product)
        {
            _product = product;
        }
        public IActionResult SprintTasks()
        {
            return View();
        }
        public IActionResult Greetings()
        {
            ViewData["Message"] = "Hello C# Marathon!";
            ViewData["Title"] = "Greetings - ViewTask";
            ViewData["Greeting"] = "Welcome to our project!";
            int hour = DateTime.Now.Hour;
            if (hour >= 0 && hour < 6)
            {
                ViewData["Night"] = "Good night!";
            }
            else if (hour >= 6 && hour < 12)
            {
                ViewData["Morning"] = "Good Morning!";
            }
            else if (hour >= 12 && hour < 18) { ViewData["Day"] = "Good day!"; }
            else { ViewData["Evening"] = "Good evening!"; }
            return View();
        }
        public IActionResult ProductInfo()
        {
      
            return View();
        }
    }
}
