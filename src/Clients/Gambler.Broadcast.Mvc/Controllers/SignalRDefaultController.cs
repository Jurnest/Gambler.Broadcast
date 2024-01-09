using Microsoft.AspNetCore.Mvc;

namespace Gambler.Broadcast.Mvc.Controllers;
public class SignalRDefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
