using Microsoft.AspNetCore.Mvc;

namespace NoWindsor.Controllers
{
  public class ApplicationController : Controller
  {
    [HttpGet] public string Hello() => "Hello from ApplicationController";
  }
}
