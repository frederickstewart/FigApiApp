
using Microsoft.EntityFrameworkCore;

using System.Diagnostics.CodeAnalysis;

namespace FigApiApp.Models
{
   public class PlayerContext : DbContext
   {
      public PlayerContext(DbContextOptions<PlayerContext> options) : base(options)
      {
         Database.EnsureCreated();
      }

      public DbSet<Player> Players { get; set; } = null!;

   }
}