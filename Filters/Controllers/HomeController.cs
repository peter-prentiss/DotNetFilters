using Microsoft.AspNetCore.Mvc;
using Filters.Infrastructure;

namespace Filters.Controllers
{
    [Profile]
    [ViewResultDetails]
    public class HomeController : Controller
    {
        public ViewResult Index() => View("Message",
            "This is the Index action on the Home controller");
    }
}