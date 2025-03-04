using _02_demo_of_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVC_02.Controllers
{
    // MVC Controller
    public class movieController : Controller
    {
        // Action       :: Public Non Static Functions
        // Actions      :: Have Special Return Type
        // ActionResult :: 
        // public string GetMovie(int id) => $"Get Movie By Id :: {id}";
        public string AddMovie(int id) => $"Add Movie By Id :: {id}";
        //public ContentResult GetMovie(int id)
        //{
        //    var ContentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie By Id :: {id}",
        //        ContentType = "text/html",
        //        StatusCode = 200
        //    };
        //    return ContentResult;
        //}

        //public ContentResult GetMovie(int id)
        //{
        //    var ContentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie By Id :: {id}",
        //        ContentType = "object/pdf",
        //        StatusCode = 200
        //    };
        //    return ContentResult;
        //}

        //public RedirectResult GetMovie(int id)
        //{
        //    var RedirectResult = new RedirectResult("https://github.com/login");
        //    return RedirectResult;
        //}

        //public RedirectToActionResult GetMovie(int id)
        //{
        //    var RedirectToActionResult = new RedirectToActionResult("AddMovie","movie",new { id = 122});
        //    return RedirectToActionResult;
        //}
        //[ActionName("GetMovie")]
        //[HttpGet]
        //[HttpPost]
        //public IActionResult GetMovieByIdAndCategoryDramaAndPoster(int id)
        //{
        //   if (id == 0)
        //   {
        //       //var ContentResult = new ContentResult(){Content = $"Get Movie By Id :: {id}",ContentType = "text/html",StatusCode = 200};
        //       return Content($"Get Movie By Id :: {id}", "text/html");
        //   }
        //    else if (id == 2)
        //   {
        //        //var ContentResult = new ContentResult() { Content = $"Get Movie By Id :: {id}", ContentType = "object/pdf", StatusCode = 200 };
        //        return Content($"Get Movie By Id :: {id}", "object/pdf");
        //   }
        //   else if (id== 3)
        //   {
        //        //return new RedirectResult( "https://WWW.google.com/"); 
        //        return Redirect("https://WWW.google.com/");
        //   }
        //   else
        //   {
        //        //return new RedirectToActionResult("AddMovie", "movie", new {id=33});
        //        return RedirectToAction("AddMovie", "movie", new { id = 33 });
        //    }

        //}

        // Action Parameters Binding
        // 1. query 
        // 2. seqment
        // 3. query params
        // 4. files
        public IActionResult GetMovie(Movie movie)
        {
            return Content($"Get Movie By Id :: {movie.Id} , Name : {movie.Name}", "text/html");
        }
    } 
}
