using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;

namespace FigApiApp.Models
{
   public class Team : TeamRepository
   {
      /// <summary>
      /// Unique Identifier for specified Team.
      /// </summary>
      public int Id { get; set; }

      /// <summary>
      /// Official Team Name.
      /// </summary>
      [Required]
      public string Name { get; set; }

      /// <summary>
      /// Home City for the Team.
      /// </summary>
      [Required]
      public string Location { get; set; }

      /// <summary>
      /// List of all the players on the Team.
      /// </summary>
      [MaxLength(8)]
      public List<Player> Players { get; set; }

      /// <summary>
      /// Context Constructor.
      /// </summary>
      /// <param name="context"></param>
      public Team(TeamContext context, string name, string location, List<Player> players) : base(context)
      {
         Name = name;
         Location = location;
         Players = players;
      }
   }

   public class TeamRepository
   {
      private readonly TeamContext _context;

      public TeamRepository(TeamContext context)
      {
         _context = context;
      }
   }

   public class TeamContext : DbContext
   {
      public TeamContext(DbContextOptions<TeamContext> options) : base(options)
      {
         Database.EnsureCreated();
      }

      public DbSet<Team> Teams { get; set; } = null!;
   }
}
