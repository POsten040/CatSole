using Spectre.Console;

namespace CatSole.Helpers
{
  public class AH
  {
    private static Canvas c = new Canvas(32, 8); 
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
      // double step = (2*Math.PI)/20;
      // int edge = c.Width;
      // for(int i=0; i<2*Math.PI; i++)
      // {
      //   c.SetPixel(randy.Next(c.Width), randy.Next(c.Height), colorList[randy.Next(colorList.Count)]);
      // }
      for(int i=0; i<c.Width && i<c.Height; i++)
      {
        c.SetPixel(randy.Next(c.Width), randy.Next(c.Height), colorList[randy.Next(colorList.Count)]);
      }
      AnsiConsole.Write(c);
    }
    public static void Spin()
    {
    AnsiConsole.Status()
      .Spinner(Spinner.Known.Star)
      .Start("Hang on a sec...", ctx => {
          Console.WriteLine(ctx);
      });
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
    public static void MakeBar(Dictionary<string, int> keys)
    {
      BreakdownChart bd = new BreakdownChart().Width(60);
      int index = 0;
      foreach(KeyValuePair<string, int> kv in keys)
      {
        bd.AddItem(kv.Key, kv.Value, colorList[index]);
        index++;
      }
      AnsiConsole.Write(bd);
    }
    public static string Ask(string message, string word = "thing")
    {
      var result = AnsiConsole.Ask<string>($"[white]{message}[/] [green]{word}[/]?");
      return result;
    }
    public static void Figlet(string message)
    {
      AnsiConsole.Write(
        new FigletText($"{message}")
        .LeftAligned()
        .Color(Color.Green));
    }
  }
}