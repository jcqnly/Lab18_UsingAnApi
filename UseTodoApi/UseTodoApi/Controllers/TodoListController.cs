﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UseTodoApi.Models;

namespace UseTodoApi.Controllers
{
    public class TodoListController : Controller
    {
        public async Task<IActionResult> ViewAllLists()
        {
            using (HttpClient client = new HttpClient())
            {
                // add the appropriate properties on top of the client base address.
                client.BaseAddress = new Uri("http://artisanalapi.azurewebsites.net");

                //the .Result is important for us to extract the result of the response from the call
                var response = client.GetAsync("api/todolist").Result;

                if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
                {
                    var stringResult = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<List<TodoList>>(stringResult);
                    return View(obj);
                }
            }
            return View();
        }
    }
}
