using Microsoft.AspNetCore.Mvc;

namespace MVC_02.Controllers
{
    // MVC Controller
    public class movieController : Controller
    {
        // Action :: Public Non Static Functions
        public string GetMovie(int id) => $"Get Movie By Id :: {id}";
        public string AddMovie(int id) => $"Add Movie By Id :: {id}";
    }
}
