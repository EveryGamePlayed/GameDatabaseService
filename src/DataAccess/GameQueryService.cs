using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<Game> GetGameByIdAsync(int id) => await _context.Games.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<List<Game>> GetGamesAlphabeticallyAsync(int start, int end) => await _context.Games
            .OrderBy(x => string.IsNullOrWhiteSpace(x.SortTitle) ? x.Title : x.SortTitle).Skip(start).Take(end)
            .ToListAsync();
    }
}
