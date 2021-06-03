namespace BrokerSite.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class RentController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
