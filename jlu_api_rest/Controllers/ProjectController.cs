﻿using Microsoft.AspNetCore.Mvc;

namespace jlu_api_rest.Controllers
{
    public class ProjectController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}