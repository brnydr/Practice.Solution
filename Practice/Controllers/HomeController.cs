using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
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