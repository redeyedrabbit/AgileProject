using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgileProject.Controllers
{
    public class GenreController : ApiController
    {
        // Get All Genres
        public IHttpActionResult Get()
        {
            GenreService genreService = CreateGenreService();
            var genres = genreService.GetGenre();
            return Ok(genres);
        }

        // Get Genre by Game Title
        public IHttpActionResult Get(int id)
        {
            GenreService genreService = CreateGenreService();
            var genre = genreService.GetGenreByGameId(id);
            return Ok(genre);
        }
    }
}
