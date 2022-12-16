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
        "Welcome to the game, please press one of the number keys.",
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
        "Hey friend, you may want to see a doctor. But first PRESS THE NUMBER KEYS",
        "Fat fingers no singers",
        new string[]{"Finger", "Singer"},
        "Do you want to know a secret?",
        new string[]{"not really", "nope"},
        "laughed"
      ),
      new Prompt(
        "I'm really worried about you SUBJECT-6394NF9W-02",
        "You had one job...",
        new string[]{":0", "D:"},
        "Check this drawing out, I mean being cool is a waste of time right?!",
        new string[]{"Ice cold!", "Alright alright alright alright alright"},
        "laughed"
      ),
      new Prompt(
        "Lets get crazy and, press one of the number keys",
        "slipping in the end zone ey?",
        new string[]{"B===>~~", "80085"},
        "Hey kid, stop all the downloading!",
        new string[]{"Sir, this is a Wendy's", "I'm a cat"},
        "laughed"
      ),
      new Prompt(
        "Welp. ¯|_(ツ)_/¯ good luck, godspeed, I love you",
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