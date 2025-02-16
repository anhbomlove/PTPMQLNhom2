using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers{
    public class EmployeeController : Controller
    { 
        // GET: /Employee/
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
