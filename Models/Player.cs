using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;

namespace FigApiApp.Models
{
   public class Player : PlayerRepository
   {
      /// <summary>
      /// Unique Identifier for specified Player
      /// </summary>
      public int Id { get; set; }

      /// <summary>
      /// First Name of the Player
      /// </summary>
      [Required]
      public string FirstName { get; set; }

      /// <summary>
      /// Last Name of the Player.
      /// </summary>
      [Required]
      public string LastName { get; set; }

      /// <summary>
      /// Team Id Number for Players assigned Team.
      /// </summary>
      public int TeamId { get; set; }

      /// <summary>
      /// Context constructor.
      /// </summary>
      /// <param name="context"></param>
      public Player(PlayerContext context) : base(context) { }
   }

   public class PlayerRepository
   {
      private readonly PlayerContext _context;

      public PlayerRepository(PlayerContext context)
      {
         _context = context;
      }
   }

   public class PlayerContext : DbContext
   {
      public PlayerContext(DbContextOptions<PlayerContext> options) : base(options)
      {
         Database.EnsureCreated();
      }

      public DbSet<Player> Players { get; set; } = null!;

   }
}
