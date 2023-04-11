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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public ActionResult<Music> Get(int id)
        {
            Music? foundMusic = _musicRepository.GetbyID(id);
            if (foundMusic == null)
            {
                return NotFound();
            }
            return Ok(foundMusic);
            
        }

        // POST api/<MusicController>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<Music> Post([FromBody] Music newMusic)
        {
            try
            {
                Music createdMusic = _musicRepository.Add(newMusic);
                return Created($"api/musics/{createdMusic.Id}",createdMusic);

            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<MusicController>/5
        [HttpPut("{id}")]
        public ActionResult<Music> //Put(int id, [FromBody] Music updates);
        {

        }

        // DELETE api/<MusicController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
