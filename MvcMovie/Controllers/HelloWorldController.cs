using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        // A view template file name wasn't specified, so MVC defaulted to using the default view file.
        // When the view file name isn't specified, the default view is returned. The default view has the same name as the action method
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/
        // Uses HtmlEncoder.Default.Encode to protect the app from malicious input, such as through JavaScript. (return string)
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
