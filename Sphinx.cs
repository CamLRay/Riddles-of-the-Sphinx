using System;
using System.Collections.Generic;

class Program 
{
  static void Main()
  {
    Dictionary<string, string> riddles = new Dictionary<string, string>() {{"Man", "What goes on four legs in the morning, two legs in the afternoon, and three legs in the evening?"}};
    string question = "Man";
    Console.WriteLine(riddles[question]);
    string answer = Console.ReadLine();
    if(question == answer)
    {
      Console.WriteLine("Correct!");
    }
    else
    {
      Console.WriteLine("Incorrect, the Sphinx eats you.");
    }
  }
}


