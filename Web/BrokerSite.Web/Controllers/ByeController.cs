﻿namespace BrokerSite.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ByeController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
