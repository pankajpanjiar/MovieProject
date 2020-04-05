using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class MovieController: Controller
    {
        public IActionResult Index()
        {
            //This is default Action
            return View();
        }

        public string Welcome(string name, int id = 0)
        {
            return $"Welcome {name} with id {id}";
        }


    }
}