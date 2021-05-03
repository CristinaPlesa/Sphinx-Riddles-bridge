namespace Sphinx.Models 
{
  public class Riddle
  {
    public string Question;
    public string Answer;
  
    public Riddle(string question, string answer)
    {
      Question = question;
      Answer = answer;
    }
  }  
}