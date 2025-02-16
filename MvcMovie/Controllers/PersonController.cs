
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers{
    public class PersonController : Controller
    { 
        // GET: /Person/
        public IActionResult Index()
        {
            return View();
        } 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "hello";
        }
    }
}
