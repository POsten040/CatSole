using Spectre.Console;

namespace CatSole.Helpers
{
  public sealed class SpinBro : Spinner
  {
      // The interval for each frame
      public override TimeSpan Interval => TimeSpan.FromMilliseconds(350);
      
      // Whether or not the spinner contains unicode characters
      public override bool IsUnicode => false;

      // The individual frames of the spinner
      public override IReadOnlyList<string> Frames => 
          new List<string>
          {
              ".", "..", "...",
          };
  }
}
