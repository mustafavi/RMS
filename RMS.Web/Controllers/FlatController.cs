using Microsoft.AspNetCore.Mvc;

namespace RMS.Web.Controllers
{
    public class FlatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
