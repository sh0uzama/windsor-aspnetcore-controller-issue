using Microsoft.AspNetCore.Mvc;

namespace WindsorWorking.Controllers
{
  public class ApplicationController : Controller
  {
    [HttpGet] public string Hello() => "Hello from ApplicationController";
  }
}
