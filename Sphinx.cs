using System;
using System.Collections.Generic;

class Program 
{
  static void Main()
  {
    Dictionary<string, string> riddles = new Dictionary<string, string>() {{"man", "What goes on four legs in the morning, two legs in the afternoon, and three legs in the evening?"}, {"a towel", "What gets wet while drying?"}, {"nothing", "The poor have me; the rich need me. Eat me and you will die. What am I?"}, {"a deck of cards", "What has 13 hearts but no other organs?"}};
    List<string> answerKey = new List<string>(0) {};

    foreach (KeyValuePair<string, string> entry in riddles)
    {
      answerKey.Add(entry.Key);
    }
    
    for (int i=0; i < riddles.Count; i++)
    {
      Random rnd = new Random();
      int num = rnd.Next(answerKey.Count);
      string question = answerKey[num];
      Console.WriteLine(riddles[question]);
      string answer = Console.ReadLine();
      if(question == answer.ToLower())
      {
        Console.WriteLine("Correct!");
        answerKey.Remove(answerKey[num]);
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
// int num = rnd.Next(4);
