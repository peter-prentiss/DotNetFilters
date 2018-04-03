﻿using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("Message",
            "This is the Index action on the Home controller");
    }
}