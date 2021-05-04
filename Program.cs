using System;
using System.Collections.Generic;
using Sphinx.Models;

namespace Bridge
{
  public class Program
  {
    public static void Main()
    {
      Riddle one = new Riddle("What is your favorite color", "blue");
      Riddle two = new Riddle("I’m tall when I’m young, and I’m short when I’m old. What am I?","a candle");
      Riddle three = new Riddle("What month of the year has 28 days?","all of them");
      Riddle four = new Riddle("What is always in front of you but can’t be seen?","the future");
      Riddle five = new Riddle("What is full of holes but still holds water?","a sponge");
      Riddle six = new Riddle("I shave every day, but my beard stays the same. What am I?","a barber");
      
      List<Riddle> Riddles = new List<Riddle>() { one, two, three, four, five, six };

      int correctCounter = 0;

      while (correctCounter < 3)
      {
        Console.WriteLine(Riddles[correctCounter].Question);
        string guess = Console.ReadLine();
        if (correctCounter == 3)
        {
          Console.WriteLine("Your general knowledge has vanquished me!");
          break;
        }
        else if (guess != Riddles[correctCounter].Answer)
        {
          Console.WriteLine("You are wrong and so I must eat you.");
          break;
        }
        else if (guess == Riddles[correctCounter].Answer)
        {
          correctCounter++;
        }
        //Console.WriteLine("Your general knowledge has vanquished me!");
      }
      

      // Console.WriteLine(one.Question);
      // string guess = Console.ReadLine();
      // if (guess != one.Answer)
      // {
      //   Console.WriteLine("You are wrong and so I must eat you.");
      // }
      // else if (guess == one.Answer)
      // {
      //   Console.WriteLine("Your general knowledge has vanquished me!");
      // }
    }
  }
}

//Riddle num = new Riddle("","");