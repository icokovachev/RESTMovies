using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTMovies.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenresController : ControllerBase
    {
        private static readonly string[] Genres = new[]
        {
            "Drama", "Action", "Comedy", "Fantasy", "Horror", "Mystery", "Romance", "Thriller"
        };

        private readonly ILogger<GenresController> _logger;

        public GenresController(ILogger<GenresController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            foreach (string genre in Genres) {
                yield return genre;
            }
        }
    }
}
