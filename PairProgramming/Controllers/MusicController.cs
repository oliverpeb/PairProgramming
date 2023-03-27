using Microsoft.AspNetCore.Mvc;
using PairProgramming.Models;
using PairProgramming.Repositories;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PairProgramming.Controllers
{
    [Route("api/[controller]")]
    //URI: api/PairProgramming
    [ApiController]
    public class MusicController : ControllerBase
    {
        private MusicRepository _musicRepository;

        public MusicController(MusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
        }


        // GET: api/<MusicController>
        [HttpGet]
        public IEnumerable<Music> Get()
        {
            List<Music> result = _musicRepository.GetAll();
            return result;
              
        }

        // GET api/<MusicController>/5
        [HttpGet("{id}")]
        //public Music Get(int id)
        //{
            
        //}

        // POST api/<MusicController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<MusicController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<MusicController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
