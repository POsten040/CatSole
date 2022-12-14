namespace CatSole.Helpers
{
  public class Prompt
  {
    public string Welcome {get; set;}
    public string BadResponse {get; set;}
    public string[] Shouts {get; set;}
    public string Question {get; set;}
    public string[] Choices {get; set;}
    public string PointTarget {get; set;}
    public Prompt(string welcome, string badResponse, string[] shouts, string question, string[] choices, string point)
    {
      Welcome = welcome;
      BadResponse = badResponse;
      Shouts = shouts;
      Question = question;
      Choices = choices;
      PointTarget = point;
    }
  }
}