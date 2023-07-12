using Movies_Record_.NetCoreWebApi6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Movies_Record_.NetCoreWebApi6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieContext _dbContext;

        public MoviesController(MovieContext dbContext) 
        {
            _dbContext = dbContext;
        }
    }
}
