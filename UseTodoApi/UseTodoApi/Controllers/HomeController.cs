using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UseTodoApi.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Directs the user to the index page where the user can
        /// view the Todo lists and items for each list
        /// </summary>
        /// <returns></returns>
        //[HttpGet]
        public IActionResult Index()
        {
            return View();
        }


    }
}
