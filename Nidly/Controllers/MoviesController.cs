using Nidly.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Web.Configuration;
using Nidly.ViewModels;

namespace Nidly.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return  new List<Movie>
            {
                 new Movie {Id = 1, Name = "3 Idiot"},
                 new Movie {Id = 2, Name = "Koi Mil Gya"}
            };
    }

    // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = " Krish 2 !" };

           // Customer customer = new Customer();

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customers
            };

           
            // var viewResult = new ViewResult();
           // viewResult.ViewData.Model = viewModel;
            
             
            return View(viewModel); 

        }



    }
}