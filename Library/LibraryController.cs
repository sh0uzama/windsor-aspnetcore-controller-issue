using Microsoft.AspNetCore.Mvc;

namespace Library
{
  public class LibraryController : ControllerBase
  {
    [HttpGet] public string Hello() => "Hello from LibraryController";
  }
}
