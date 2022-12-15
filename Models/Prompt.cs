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
    public static List<Prompt> prompts = new List<Prompt>
    {
      new Prompt(
        "Welcome to the game, please press one of the num keys.",
        "Yeah but not that one",
        new string[]{"Eyyyy", "Oohhh"},
        "what do you think of that? I just did that.",
        new string[]{"it's art", "it's a fart"},
        "art appreciator"
      ),
      new Prompt(
        "Trying again huh? you remember what to do?",
        "Nah nah nahnahnah",
        new string[]{"whoa!", "noice"},
        "What's the best smell?",
        new string[]{"honey", "suckle"},
        "art appreciator"
      ),
      new Prompt(
        "Hey friend, you may want to see a doctor",
        "A load of bog standard plonk",
        new string[]{"commit", "drive"},
        "Do you want to know a secret?",
        new string[]{"not really", "nope"},
        "laughed"
      ),
      new Prompt(
        "I'mreally worried about you",
        "You had one job...",
        new string[]{"Shout", "Shout"},
        "Being cool is a waste of time right?!",
        new string[]{"Ice cold!", "Alright alright alright alright alright"},
        "laughed"
      ),
      new Prompt(
        "LAST CALL DAWG",
        "slipping in the end zone ey?",
        new string[]{"Something", "something"},
        "Hey kid, stop all the downloading!",
        new string[]{"Sir, this is a Wendy's", "I'm a cat"},
        "laughed"
      ),
      new Prompt(
        "JK this is the final message, good luck, godspeed, I love you",
        "On this day of all days!?",
        new string[]{"Leeeeeeeeeroy", "jeeeeeenkins"},
        "Rate my drawing again",
        new string[]{"100 yeets", "100 beets"},
        "art appreciator"
      )
    };
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