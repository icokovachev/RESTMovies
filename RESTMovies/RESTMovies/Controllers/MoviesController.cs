using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTMovies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static string[] Movies = new string[] {
        "Braveheart (Mel Gibson)", "Geostorm"
        };

        // GET: api/Movies
        [HttpGet]
        public IEnumerable<string> Get()
        {
            foreach (string movie in Movies) {
                yield return movie;
            }   
        }


        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return Movies[id];
        }
    }
}
