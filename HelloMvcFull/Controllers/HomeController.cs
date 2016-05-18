using Microsoft.AspNetCore.Mvc;

namespace HelloMvcFull
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index() => View();
    }
}