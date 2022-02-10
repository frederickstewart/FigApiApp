using FigApiApp.Models;

namespace FigApiApp.Repositories
{
   public interface IPlayerRepository
   {
      Task<IEnumerable<Player>> Get();
      Task<Player> Get(int id);
      Task<IEnumerable<Player>> Get(string lastName);
      Task<IEnumerable<Player>> Get(string firstName, string lastName);
      Task<Player> Create(Player player);
      Task Update(Player player);
      Task Delete(int id);
   }
}