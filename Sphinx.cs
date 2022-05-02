using System;
using System.Collections.Generic;

class Program 
{
  static void Main()
  {
    Dictionary<string, string> riddles = new Dictionary<string, string>() {{"man", "What goes on four legs in the morning, two legs in the afternoon, and three legs in the evening?"}, {"a towel", "What gets wet while drying?"}};
    string[] answerKey = {"man", "a towel"};
    for (int i=0; i < answerKey.Length; i++)
    {
      string question = answerKey[i];
      Console.WriteLine(riddles[question]);
      string answer = Console.ReadLine();
      if(question == answer.ToLower())
      {
        Console.WriteLine("Correct!");

      }
      else
      {
        Console.WriteLine("Incorrect, the Sphinx eats you.");
        break;
      }
    }
  }
}

// Random rnd = new Random();
    // int num = rnd.Next(3);
