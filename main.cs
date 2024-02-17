using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter a text: ");

    string combinedWords = "";

    
    while (true)
    {
      string input = Console.ReadLine();

      if (input.ToLower () == "exit")
      {
        Console.WriteLine("Closing program...");
        break;
      }

      combinedWords += input + "";
      Console.WriteLine("Enter a text: " + combinedWords.Trim());
    }
    
  }
  }
