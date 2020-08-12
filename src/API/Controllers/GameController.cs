using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using DataAccess.QueryServices.Interfaces;
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
        public async Task<ActionResult<GameDto>> GetGameByIdAsync(int id)
        {
            var game = await _gameQueryService.GetGameByIdAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            return Ok(new GameDto(game));
        }

        /// <summary>
        /// Gets Games Alphabetically with Limits for infinite scroll/pagination
        /// </summary>
        /// <param name="start">Start of the selection</param>
        /// <param name="end">End of the selection</param>
        /// <returns>List of Game information</returns>
        [HttpGet]
        public async Task<ActionResult<List<GameDto>>> GetGamesAlphabeticallyAsync(int start, int end)
        {
            var games = await _gameQueryService.GetGamesAlphabeticallyAsync(start, end);
            var list = games.Select(game => new GameDto(game)).ToList();
            return Ok(list);
        }

        [HttpGet]
        public async Task<ActionResult<List<GameDto>>> GetGameBySearchString(string searchString)
        {
            var games = await _gameQueryService.GetGamesFromSearchString(searchString);
            var list = games.Select(game => new GameDto(game)).ToList();
            return Ok(list);
        }
    }
}
