using System;

namespace SphinxRiddle.Models {
  
  public class Sphinx
  {
    public string RiddleQ { get; set; }
    public string Answer { get; set; }

    public Sphinx(string question, string answer)
    {
    RiddleQ = question;
    Answer = answer;
    }
    
    public string GetRiddle() 
    {
    return RiddleQ;
    }

    public string GetAnswer()
    {
      return Answer;
    }
  
    public void SetRiddle(string newRiddle)
    {
      RiddleQ = newRiddle;      
    }

    public void setAnswer(string newAnswer)
    {
      Answer = newAnswer;
    }
    
    /*static void generator()
    {
      Random randy = new Random();
      for (int i = 0; i < 6; i++) 
      {
        int[i] num = randy.next(1,6);
      }

    return num;
    }*/
  }
}
