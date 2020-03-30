using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
0> Random.cshtml @ViewBag.Movie
            return View(viewModel);
        }

        public ActionResult Edit(int id) { //moviesId ---> query string ?moviesId=[value]
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy) {
            if (!pageIndex.HasValue) pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy)) sortBy = "Name";
            return Content(String.Format("pageIndex = {0}&sortBy={1}", pageIndex, sortBy)); //localhost:58558/movies
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month){ //localhost:58558/movies/released/2018/08
            return Content(year + "/" + month);
        }
    }
}