using Microsoft.AspNetCore.Mvc;

namespace WindsorNotWorking.Controllers
{
  public class ApplicationController : Controller
  {
    [HttpGet] public string Hello() => "Hello from ApplicationController";
  }
}
