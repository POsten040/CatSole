using System;
using CatSole.Helpers;

public static class Program
{
  private static string rightThing = "did the right thing";
  private static string wrongThing = "did the wrong thing";
  private static string laughed = "laughed";
  public static Dictionary<string, int> stats = new Dictionary<string, int>()
    {
      {rightThing,0},
      {wrongThing,0},
      {laughed,0}
    };
  public static List<ConsoleKeyInfo> KeyLog = new List<ConsoleKeyInfo> {};
  private static List<char> _acceptableKeys = new List<char>
  {
    '1','2','3','4','5','6','7','8','9'
  };
  public static void Main()
  {
    AH.Write("hello you beautiful craig, press one of those numm pad keys", "aqua", "beautiful", "purple");
    ConsoleKeyInfo key = Console.ReadKey();
    // Console.WriteLine(key.KeyChar);
    if(KeyGood(key))
    {
      AH.Write("Eyyyy", "greenyellow");
      AH.Write("", "greenyellow");
      AH.Write("Ohhh", "greenyellow");
    }
    else
    {
      AH.Write("Yeah but not that one", "darkgoldenrod");
    }
  }
  private static bool KeyGood(ConsoleKeyInfo key)
  {
    char keyChar = key.KeyChar;
    foreach(char character in _acceptableKeys)
    {
      if(character == keyChar) return true;
    }
    return false;
  }
  private static void LogKey(ConsoleKeyInfo key)
  {
    KeyLog.Add(key);
  }
  private static void AddStat(string action)
  {
    stats[action]++;
  }
  private static void Reset()
  {
    Main();
  }
}