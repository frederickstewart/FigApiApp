namespace FigApiApp.Classes
{
   public class Team
   {
      /// <summary>
      /// Int value identifying a specific record by key.
      /// </summary>
      public int ID { get; set; }

      /// <summary>
      /// Name of the team.
      /// </summary>
      public string Name { get; set; }

      /// <summary>
      /// The location of the Team.
      /// </summary>
      public string Location { get; set; }

      /// <summary>
      /// A List of Player types that is composed of all Players on the Team.
      /// </summary>
      public List<Player> PlayerList{ get; set; }
      
   }
}
