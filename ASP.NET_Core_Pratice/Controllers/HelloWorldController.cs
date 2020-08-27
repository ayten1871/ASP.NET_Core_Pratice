using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Pratice.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
            // return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(String name, int numTimes = 4)
        {

            ViewData["Message"] = "Hello" + name;
            ViewData["numTimes"] = numTimes;
            return View();
            //return HtmlEncoder.Default.Encode($"Hello{name}, ID :{ID}");
        }
    }
}
