using Spectre.Console;

namespace CatSole.Helpers
{
  public class AH
  {
    private static Canvas c = new Canvas(3, 3); 
    public static void Write(string message, string color)
    {
      AnsiConsole.Markup($"[{color}]{message}[/]");
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
          result += word;
        }
      }
      result += "[/]";
      AnsiConsole.Markup(result);
    }
    public static void Draw(int x, int y)
    {
      c.SetPixel(x, y, Color.White);
    }
    // public static void Draw(int x, int y, string color)
    // {
    //   Color SpectreColor = new Color(color);
    //   c.SetPixel(x, y, SpectreColor);
    // }
  }
}