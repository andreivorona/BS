﻿namespace BrokerSite.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
