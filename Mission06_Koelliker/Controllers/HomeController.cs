using Microsoft.AspNetCore.Mvc;
using Mission06_Koelliker.Models;
using System.Diagnostics;

namespace Mission06_Koelliker.Controllers
{
    public class HomeController : Controller
    {
        private MyMoviesContext _context;

        public HomeController(MyMoviesContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();

        }
        public IActionResult GetToKnowJoel()
        {  return View(); 
        
        
        }
        [HttpPost]
        public IActionResult AddMovie(Movies response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("AddMovie");
        }
         
       
    }
}
