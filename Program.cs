using CatSole.Helpers;

public static class Program
{
  private static int iteration = -1;
  private static string defaultColor = "aqua";
  private static string accent = "white";
  private static string sus = "fuchsia";
  private static string warn = "red";
  private static string tableColor1 = "indianred";
  private static string tableColor2 = "darkslategray1";
  private static Stats userStats = new Stats();
  public static Dictionary<string, int> KeyLog = new Dictionary<string, int> {};
  private static List<char> _acceptableKeys = new List<char>
  {
    'n','u','m','b','e','r'
  };
  public static void Main()
  {
    if(iteration == -1)
    {
      string userName = AH.Ask("Tell me your", "name");
      userStats.Name = userName;
      AH.Write($"Nice to meet you {userStats.Name}", defaultColor);
    }
    Iterate(Prompt.prompts.Count);
    if(iteration >= Prompt.prompts.Count) WriteStats(userStats);
    Prompt currentPrompt = Prompt.prompts[iteration];
    Greeting(currentPrompt.Welcome);
    ConsoleKeyInfo key = Console.ReadKey();
    LogKey(key);
    if(KeyGood(key.KeyChar))
    {
      userStats.AddStat(Stats.rightThing);
      if(iteration%2==0) AH.Figlet(currentPrompt.Shouts[0]);
      else  AH.Figlet(currentPrompt.Shouts[1]);
      AH.Draw();
      string response = AH.GiveOptions(currentPrompt.Question, tableColor1, tableColor2, currentPrompt.Choices);
      if(response == currentPrompt.Choices[0]) userStats.AddStat(currentPrompt.PointTarget);
      Reset(userStats, Prompt.prompts.Count);
    }
    else
    {
      userStats.AddStat(Stats.wrongThing);
      AH.Write(currentPrompt.BadResponse, sus);
      Reset(userStats, Prompt.prompts.Count);
    }
  }
//-----------------Methods-----------------\
  private static bool KeyGood(char keyChar)
  {
    foreach(char character in _acceptableKeys)
    {
      if(character == keyChar) return true;
    }
    return false;
  }
  private static void LogKey(ConsoleKeyInfo key)
  {
    string keyChar = key.KeyChar.ToString();
    if(KeyLog.ContainsKey(keyChar)) KeyLog[keyChar]++;
    if(!KeyLog.ContainsKey(keyChar)) KeyLog[keyChar] = 1;
  }

  public static void Iterate(int count)
  {
    if(iteration>=count) iteration = count;
    else iteration++;
  }
  private static void Greeting(string message)
  {
    if(iteration >= 6) AH.Write(":skull_and_crossbones:", accent);
    if(iteration == 4) AH.MakeTable("bruh", "...");
    if(iteration == 2) AH.MakeTable("Hello", "...again");
    if(iteration == 0) AH.MakeTable("Hello", "world");
    AH.Write(message, defaultColor);
  }
  private static void Reset(Stats user, int count)
  {
    
    if(iteration >= count) 
    {
      WriteStats(user);
    }
    string morale = "";
    if(iteration%3==0)
    {
      AH.Write("Hey you've been working hard", defaultColor, " hard", accent);
      morale = AH.GiveOptions("Quit?", "yellow", sus, new string[]{"Okay", "Eat my shorts"});
    }
    if(morale == "Okay") 
    {
      WriteStats(user);
    }
    Main();
  }
  private static void WriteStats(Stats user)
  {
    AH.Write($"this is the end {user.Name}, here lay your stats", defaultColor);
    foreach(KeyValuePair<string, int> k in user.stats)
    {
      AH.MakeTable(k.Key, k.Value.ToString());
    }
    AH.Write("You pressed these keys", defaultColor);
    AH.MakeBar(KeyLog);
    AH.Write("press f to say goodbye", defaultColor);
    ConsoleKeyInfo key = Console.ReadKey();
    AH.Figlet($"Bye {user.Name}");
    Environment.Exit(0);
  }
}