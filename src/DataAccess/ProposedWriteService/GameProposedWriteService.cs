using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DataAccess.ProposedWriteService.Interfaces;
using DataAccess.ProposedWriteService.ProposedDtos;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.DomainEntities;
using Models.Enums;
using Models.ProposedChanges;

namespace DataAccess.ProposedWriteService
{
    public class GameProposedWriteService : IGameProposedWriteService
    {
        private readonly GameDbContext _context;

        public GameProposedWriteService(GameDbContext context)
        {
            _context = context;
        }

        public async Task<ProposedChanges> WriteProposedChanges(ProposedGameDto proposedGame)
        {
            var serializedGameChanges = JsonSerializer.Serialize(proposedGame);

            var existingChange = await _context.ProposedChanges.Where(x =>
                x.ChangeType == ChangeType.Game && x.ProposedDataChanges == serializedGameChanges).FirstOrDefaultAsync();

            if (existingChange != null)
            {
                return existingChange;
            }

            var proposedChanges = await _context.ProposedChanges.AddAsync(new ProposedChanges
            {
                ChangeType = ChangeType.Game,
                ProposedDataChanges = serializedGameChanges
            });
            
            await _context.SaveChangesAsync();

            return proposedChanges.Entity;
        }
    }
}