using System;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.DomainEntities;

namespace DataAccess
{
    public class GameQueryService : IGameQueryService
    {
        private readonly GameDbContext _context;

        public GameQueryService(GameDbContext context)
        {
            _context = context;
        }

        public async Task<Game> GetGameById(int id) => await _context.Games.FirstOrDefaultAsync(x => x.Id == id);
    }
}
