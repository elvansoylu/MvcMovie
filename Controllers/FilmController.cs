using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class FilmController : Controller
    {
        MvcMovieContext _dbErisici;
        public FilmController(MvcMovieContext servis) 
        {
            _dbErisici = servis;
        }
        public IActionResult Index()
        {
            List<Movie> filmler = _dbErisici.Movie.ToList();
            return View(filmler);
        }

        public IActionResult FilmDetay(int id)
        {
            Movie? m = _dbErisici.Movie.Where(mv => mv.Id == id).FirstOrDefault();

            if (m == null)
            {
                return View(m);
            }
            else
            {
                return View("Bulunamadi");
            }
        }
    }
}
