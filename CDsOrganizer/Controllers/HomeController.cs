using Microsoft.AspNetCore.Mvc;

namespace CDsOrganizer.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
