using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      string[] questions = {"Corinthians is the biggest champion of Campeonato Paulista", "Brazil has 4 World Cups", "Liverpool is the biggest english champion of the Champions League"};
      bool[] answers = {true, false,  true};

      bool[] response = new bool[questions.Length];

      if(questions.Length != answers.Length){
        Console.WriteLine("Answers length must be equal to Questions length!");
      }

      int askingIndex = 0;

      foreach(string question in questions) {
        
        bool inputBool;

        Console.WriteLine(question);
        Console.WriteLine("True or False?");
        string input = Console.ReadLine();
        bool isBool = Boolean.TryParse(input, out bool result);

        Console.WriteLine("\n");

        while(!isBool) {
          Console.WriteLine("Please respond with 'true or 'false'.");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out result);
        }

        response[askingIndex] = result;
        askingIndex++;

        Console.WriteLine("\n");
      }

      int scoringIndex = 0;
      int score = 0;

      foreach(bool answer in answers){
          bool inputAnswer = response[scoringIndex];
          Console.WriteLine($"Input: {inputAnswer} | Answer: {answer}");

          if(inputAnswer == answer){
            score++;
          }
          scoringIndex++;
          Console.WriteLine("\n");
      }

      Console.WriteLine($"You got {score} out of {answers.Length} correct!");
      
    }
  }
}
