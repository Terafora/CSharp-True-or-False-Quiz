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
      string[] questions = {
        "Sharks are mammals",
        "Sea otters have a favourite rock they use to break open food",
        "The blue whale is the biggest animal to have ever lived",
        "The hummingbird egg is the world's smallest bird egg"
      };
      bool[] answers = {
        false,
        true,
        true,
        true
      };
      bool[] responses = new bool[answers.Length];

      if (questions.Length != answers.Length)
      {
        Console.WriteLine("Warning, the number questions and answers are not equal.");
      }

      int askingIndex = 0;

      foreach (string question in questions)
      {
          string input;
          bool isBool;
          bool inputBool;

          Console.WriteLine(question);
          Console.WriteLine("true or false?");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);

          while(!isBool)
          {
            Console.WriteLine("Please respond with 'true' or 'false'.");
            input = Console.ReadLine();
            isBool = Boolean.TryParse(input, out inputBool);
          }

          responses[askingIndex] = inputBool;
          askingIndex++;
      }
      int scoringIndex = 0;
      int score = 0;

      foreach(bool answer in answers)
      {
        bool response = responses[scoringIndex];
        Console.WriteLine($"Input: {response} | Answer: {answer}");
        if(response == answer)
        {
          score++;
        }
        scoringIndex++;
      }
      Console.WriteLine($"You got {score} out of {questions.Length} correct!");
    }
  }
}
