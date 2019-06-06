using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieBrowser.Models;
using System.Text.RegularExpressions;

namespace MovieBrowser.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"
            };

            return View(movie);
        }
        //public ActionResult Edit(int id) 
        //{
        //    return Content("id=" + id);
        //}
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        //}

        [Route(@"Movies/ByReleasedDate/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleasedDate (int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}