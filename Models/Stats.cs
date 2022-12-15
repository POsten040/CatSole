namespace CatSole.Helpers;

public class Stats
{
  public string Name {get; set;}
  public static string rightThing = "did the right thing";
  public static string wrongThing = "did the wrong thing";
  public static string laughed = "laughed";
  public static string artAppreciator = "art appreciator";
  public Dictionary<string, int> stats = new Dictionary<string, int>()
    {
      {rightThing,0},
      {wrongThing,0},
      {laughed,0},
      {artAppreciator,0}
    };
  public Stats(string userName = "DEFAULT MEATBAG")
  {
    Name = userName;
  }
  public void AddStat(string action)
  {
    stats[action]++;
  }
};