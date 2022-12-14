using Spectre.Console;


namespace CatSole.Helpers
{
  public class AH
  {
    private static Canvas c = new Canvas(3, 3); 
    private static Random randy = new Random();
    private static List<Color> colorList = new List<Color> 
    {
      Color.Blue,
      Color.Gold3,
      Color.Green,
      Color.DeepSkyBlue1,
      Color.Wheat4,
      Color.BlueViolet
    };
    public static void Write(string message, string color)
    {
      List<string> words = message.Split(" ").ToList<string>();
      string result = $"$[{color}]";
      foreach(string word in words)
      {
        result += " " + word;
      }
      result += "[/]";
      AnsiConsole.MarkupLine(result);
      // AnsiConsole.MarkupLine($"[{color}]{message}[/]");
    }
    public static void Write(string message, string color, string wordToLight, string highlight)
    {
      List<string> words = message.Split(" ").ToList<string>();
      string result = $"$[{color}]";
      foreach(string word in words)
      {
        if(word == wordToLight)
        {
          result += $"[{highlight}]{wordToLight}[/]";
        }
        else
        {
          result += " " + word;
        }
      }
      result += "[/]";
      AnsiConsole.MarkupLine(result);
    }
    public static void MakeTable(string column1Text, string column2Text)
    {
      var table = new Table();
      table.AddColumn(new TableColumn(new Markup($"[yellow]{column1Text}[/]")));
      table.AddColumn(new TableColumn($"[blue]{column2Text}[/]"));
      AnsiConsole.Write(table);
    }
    public static void Draw()
    {
      for(int i=0; i<c.Width && i<c.Height; i++)
      {
        c.SetPixel(randy.Next(c.Width), randy.Next(c.Height), colorList[randy.Next(colorList.Count)]);
      }
      AnsiConsole.Write(c);
    }
    public static string GiveOptions(string title, string color1, string color2, string[] choices)
    {
      string choice = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title(title)
            .PageSize(4)
            .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
            .AddChoices(choices));
      return choice;
    }
  }
}