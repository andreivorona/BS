namespace BrokerSite.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
