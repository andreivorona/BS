﻿namespace BrokerSite.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
