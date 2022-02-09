using Microsoft.EntityFrameworkCore;

namespace FigApiApp.Contexts
{
   public class TeamContext : DbContext
   {
      public TeamContext(DbContextOptions<TeamContext> options) : base(options)
      {

      }

      public DbSet<TeamContext> Teams { get; set; } = null;
   }
}
