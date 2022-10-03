using Microsoft.AspNetCore.Mvc;
using Assignment_4.Managers;
using Microsoft.AspNetCore.Http;
using Assignment_1;


namespace Assignment_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballsController : ControllerBase
    {
        private readonly FootballPlayersManager _playerManager = new FootballPlayersManager();
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return _playerManager.GetAll();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public ActionResult<FootballPlayer> Get(int id)
        {
            FootballPlayer footballPlayer = _playerManager.GetById(id);
            if (footballPlayer == null) return NotFound("No such class, id: " + "" + id);
            return Ok(footballPlayer);

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public ActionResult<FootballPlayer> Post([FromBody] FootballPlayer value)
        {
            FootballPlayer footballPlayer = _playerManager.Add(value);
            return Ok(footballPlayer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        public ActionResult<FootballPlayer> Put(int id, [FromBody] FootballPlayer value)
        {
            FootballPlayer footballPlayer = _playerManager.Update(id, value);
            if (footballPlayer == null) return NotFound("There is no IPA on Id!" + " " + id);
            return Ok(value);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public ActionResult<FootballPlayer> Delete(int id)
        {
            FootballPlayer footballPlayer = _playerManager.Delete(id);
            if (footballPlayer == null) return NotFound("There is no IPA on Id" + " " + id);
            return Ok(footballPlayer);
        }
    }
}