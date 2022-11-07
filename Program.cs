using System;
using System.Collections.Generic;
using SphinxRiddle.Models;

namespace SphinxRiddle {
  public class Program
  {
    public static void Main()
    {
      Sphinx potato = new Sphinx ("What is it that has eyes and cannot see?","potato");
      Sphinx months = new Sphinx ("What month of the year has 28 days","All of them dummy");
      Sphinx keyboard = new Sphinx ("I have keys but no locks and space with no rooms. You can enter but you can’t go outside. What am I?","a keyboard");
      Sphinx butterfly = new Sphinx ("Can a butter fly?","No but a tin can");
      Sphinx planets = new Sphinx ("How can you tell that Jupiter, Saturn, Uranus, and Neptune are about to get married?","They all have rings.");
      
      List<Sphinx> rid1 = new List<Sphinx> {potato,months,keyboard,butterfly,planets};

      Console.WriteLine("Answer the Sphinx's Riddles, or else you will get eaten!");

      foreach(Sphinx riddy in rid1)
      {
        int index = 0;
        Console.WriteLine("--- SPHINX ---");
        Console.WriteLine(riddy.RiddleQ);
        string userInput = Console.ReadLine();
        
        if (userInput == riddy.Answer) {
          Console.WriteLine("--- SPHINX ---");
          Console.WriteLine("GOOD JOB. NEXT RIDDLE");
          index++;

          if (index == 3)  
          {
            Console.WriteLine("--- SPHINX ---");
            Console.WriteLine("YOU WIN. YOU CAN PASS");
            break;
          }
        
        }
        
        else
        {
          Console.WriteLine("--- SPHINX ---");
          Console.WriteLine("YOU LOOK REALLY TASTY");
          Console.WriteLine("*CHOMP*");
          break;
        }
      }
    }
  }
}