
using Microsoft.EntityFrameworkCore;

using System.Diagnostics.CodeAnalysis;

namespace FigApiApp.Models
{
   public class TeamContext : DbContext
   {
      public TeamContext(DbContextOptions<TeamContext> options) : base(options)
      {
         Database.EnsureCreated();
      }

      public DbSet<Team> Teams { get; set; } = null!;
   }
}