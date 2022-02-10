using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

using FigApiApp.Repositories;

using Microsoft.EntityFrameworkCore;

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
}
