using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      // 1
      string[] questions = {"GFC started in 2008 ? ", "Crypto Luna never drop below 5 cents ? "};
      // 2
      bool[] answers = {true, false};
      // 3
      bool[] responses = new bool[answers.Length];
      // 4
      if (answers.Length != questions.Length) 
      {
        Console.WriteLine("Warning!!! - Questions Array does not equal to Answer Array");
      }
      // 5
      int askingIndex = 0;
      // 6
      foreach (string question in questions) {
        string input;
        bool isBool;
        bool inputBool;
        Console.WriteLine(question);
        Console.Write("true or false? ");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);
        // 12
        while(!isBool) {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }
        // 13
        responses[askingIndex] = inputBool;
        askingIndex++;
        // 
      }
      // 14
      // foreach (bool response in responses) {
      //   Console.WriteLine(response);
      // }
      // 15
      int scoringIndex = 0;
      int score = 0;
      // 16
      foreach (bool answer in answers) {
        bool response = responses[scoringIndex];
        Console.Write(scoringIndex + 1 + ".");
        Console.WriteLine($"Input: {response} || Answer: {answer}");
        if (response == answer) {
          score++;
        }
        scoringIndex++;
      }
      Console.WriteLine($"You got {score} out of {questions.Length} correct! ");
    }
  
  }
}