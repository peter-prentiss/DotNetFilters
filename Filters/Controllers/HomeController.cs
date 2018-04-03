using Microsoft.AspNetCore.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers
{
    [HttpsOnly]
    public class HomeController : Controller
    {
        [RequireHttps]
        public ViewResult Index() => View("Message",
            "This is the Index action on the Home controller");
    }
}