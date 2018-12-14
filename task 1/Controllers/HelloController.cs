using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace task_1.Controllers
{
    public class HelloController : Controller
    {
        public string Index()
        {
            return "welcome to main screen for hello controller";
        }
        public string welcome()
        {
            return "welcome page";

        }
    }
}