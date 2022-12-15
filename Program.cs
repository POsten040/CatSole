using CatSole.Helpers;

public static class Program
{
  private static int iteration = -1;
  private static string rightThing = "did the right thing";
  private static string wrongThing = "did the wrong thing";
  private static string laughed = "laughed";
  public static string artAppreciator = "art appreciator";
  public static Dictionary<string, int> stats = new Dictionary<string, int>()
    {
      {rightThing,0},
      {wrongThing,0},
      {laughed,0},
      {artAppreciator,0}
    };
  private static List<Prompt> prompts = new List<Prompt>
  {
    new Prompt(
      "Welcome to the game, please press one of the num keys.",
      "Yeah but not that one",
      new string[]{"Eyyyy", "Oohhh"},
      "what do you think of that? I just did that.",
      new string[]{"it's art", "it's a fart"},
      artAppreciator
    ),
    new Prompt(
      "Trying again huh? you remember what to do?",
      "Nah nah nahnahnah",
      new string[]{"whoa!", "noice"},
      "What's the best smell?",
      new string[]{"honey", "suckle"},
      wrongThing
    ),
    new Prompt(
      "Hey friend, you may want to see a doctor",
      "A load of bog standard plonk",
      new string[]{"commit", "drive"},
      "Do you want to know a secret?",
      new string[]{"not really", "nope"},
      rightThing
    ),
    new Prompt(
      "LAST CALL DAWG",
      "slipping in the end zone ey?",
      new string[]{"Something", "something"},
      "Hey kid, stop all the downloading!",
      new string[]{"Sir, this is a Wendy's", "I'm a cat"},
      laughed
    ),
    new Prompt(
      "JK this is the final message, good luck, godspeed, I love you",
      "On this day of all days!?",
      new string[]{"Leeeeeeeeeroy", "jeeeeeenkins"},
      "Rate my drawing again",
      new string[]{"100 yeets", "100 beets"},
      artAppreciator
    )
  };
  public static Dictionary<string, int> KeyLog = new Dictionary<string, int> {};
  private static List<char> _acceptableKeys = new List<char>
  {
    'n','u','m','b','e','r'
  };
  public static void Main()
  {
    Iterate();
    Prompt currentPrompt = prompts[iteration];
    Greeting(currentPrompt.Welcome);
    ConsoleKeyInfo key = Console.ReadKey();
    LogKey(key);
    if(KeyGood(key.KeyChar))
    {
      AH.Write(currentPrompt.Shouts[0], "aqua");
      AH.Write("", "aqua");
      AH.Write(currentPrompt.Shouts[1], "aqua");
      AH.Draw();
      string response = AH.GiveOptions(currentPrompt.Question, "green", "blue", currentPrompt.Choices);
      if(response == currentPrompt.Choices[0]) stats[currentPrompt.PointTarget]++;
      Reset();
    }
    else
    {
      AH.Write("Yeah but not that one", "darkgoldenrod");
      Reset();
    }
  }
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
  private static void AddStat(string action)
  {
    stats[action]++;
  }
  public static void Iterate()
  {
    if(iteration>=4)
    {
      iteration = 4;
    }
    else
    {
      iteration++;
    }
  }
  private static void Greeting(string message)
  {
    if(iteration >= 4) AH.Write(":skull_and_crossbones:", "white");
    if(iteration == 3) AH.MakeTable("bruh", "...");
    if(iteration == 2) AH.MakeTable("hello", "it's you");
    if(iteration == 1) AH.MakeTable("Hello", "...again");
    if(iteration == 0) AH.MakeTable("Hello", "world");
    AH.Write(message, "aqua");
  }
  private static void Reset()
  {
    if(iteration >= 4) 
    {
      WriteStats();
    }
    Main();
  }
  private static void WriteStats()
  {
    AH.Write("this is the end, here lay your stats", "white");
    foreach(KeyValuePair<string, int> k in stats)
    {
      AH.MakeTable(k.Key, k.Value.ToString());
    }
    AH.Write("You pressed these keys", "white");
    AH.MakeBar(KeyLog);
    AH.Write("press f to say goodbye", "aqua");
    ConsoleKeyInfo key = Console.ReadKey();
    Environment.Exit(0);

  }
}