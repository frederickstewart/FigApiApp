using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

using FigApiApp.Repositories;

using Microsoft.EntityFrameworkCore;

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
      public List<Player> Players { get; set; }

      /// <summary>
      /// Context Constructor.
      /// </summary>
      /// <param name="context"></param>
      public Team(TeamContext context) : base(context) { }
   }
}
