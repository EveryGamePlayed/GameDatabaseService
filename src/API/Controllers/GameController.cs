using System.Threading.Tasks;
using API.DTOs;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    /// <summary>
    /// Controller to Add and Edit games to the database
    /// </summary>
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        private readonly IGameQueryService _gameQueryService;

        public GameController(IGameQueryService gameQueryService)
        {
            _gameQueryService = gameQueryService;
        }

        /// <summary>
        /// Get Game Details By Identity
        /// </summary>
        /// <param name="id">Id of the game to retrieve</param>
        /// <returns>Details of the specified game</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<GameDto>> GetGameById(int id)
        {
            var game = await _gameQueryService.GetGameById(id);
            if (game == null)
            {
                return NotFound();
            }
            return Ok(new GameDto(game));
        }
    }
}
