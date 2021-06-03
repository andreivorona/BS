namespace BrokerSite.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class SellController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
