using FigApiApp.Models;

using Microsoft.EntityFrameworkCore;

namespace FigApiApp.Repositories
{
   public class TeamRepository : ITeamRepository
   {
      private readonly TeamContext _context;

      public TeamRepository(TeamContext context)
      {
         _context = context;
      }

      public async Task<Team> Create(Team team)
      {
         _context.Teams.Add(team);
         await _context.SaveChangesAsync();

         return team;
      }

      public async Task Delete(int id)
      {
         var teamToDelete = await _context.Teams.FindAsync(id);
         _context.Teams.Remove(teamToDelete);
         await _context.SaveChangesAsync();
      }

      public async Task<IEnumerable<Team>> Get()
      {
         return await _context.Teams.ToListAsync();
      }

      public async Task<Team> Get(int id)
      {
         return await _context.Teams.FindAsync(id);
      }

      public async Task Update(Team team)
      {
         _context.Entry(team).State = EntityState.Modified;
         await _context.SaveChangesAsync();
      }
   }
}
