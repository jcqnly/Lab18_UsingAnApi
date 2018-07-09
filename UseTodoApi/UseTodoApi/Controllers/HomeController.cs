using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UseTodoApi.Models;

namespace UseTodoApi.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Directs the user to the index page where the user can
        /// view the Todo lists and items for each list
        /// </summary>
        /// <returns>View()</returns
        public IActionResult Index()
        {
            return View();
        }

    }
}
