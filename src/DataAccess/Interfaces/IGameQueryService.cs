using System.Threading.Tasks;
using Models.DomainEntities;

namespace DataAccess.Interfaces
{
    public interface IGameQueryService
    {
        Task<Game> GetGameById(int id);
    }
}