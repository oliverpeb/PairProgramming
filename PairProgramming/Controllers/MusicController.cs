using Microsoft.AspNetCore.Mvc;
using PairProgramming.Models;
using PairProgramming.Repositories;

namespace PairProgramming.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<MusicController> _logger;

        public MusicController(ILogger<MusicController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Music> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Music
            {
                
            })
            .ToArray();
        }
    }
}