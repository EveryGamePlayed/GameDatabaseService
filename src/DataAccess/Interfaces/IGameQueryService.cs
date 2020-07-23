using System.Collections.Generic;
using System.Threading.Tasks;
using Models.DomainEntities;

namespace DataAccess.Interfaces
{
    public interface IGameQueryService
    {
        Task<Game> GetGameByIdAsync(int id);

        Task<List<Game>> GetGamesAlphabeticallyAsync(int start, int end);

        Task<List<Game>> GetGamesFromSearchString(string searchString);
    }
}