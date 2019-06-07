using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieBrowser.Models;
using System.Text.RegularExpressions;
using MovieBrowser.ViewModel;
namespace MovieBrowser.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"
            };
            var customers = new List<Customer>
            {
                new Customer { Name="Customer 1"},
                new Customer { Name="Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
       

        //[Route(@"Movies/ByReleasedDate/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleasedDate (int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
    }
}