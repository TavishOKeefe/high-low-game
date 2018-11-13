using System;
using System.Runtime;

namespace HiLow {

  class Guess
  {
    private int upperBoundary;
    private int lowerBoundary;

    public Guess ()
    {
      this.upperBoundary = 100;
      this.lowerBoundary = 1;
    }

    public void StartGuess()
    {

      Random randValue = new Random();
      int guess = randValue.Next(lowerBoundary,upperBoundary);
      string guessString = guess.ToString();
      Console.WriteLine("--------------");
      Console.WriteLine("Is the value greater than {0}? Y or N?", guessString);
      string yesNo = Console.ReadLine();

      if (yesNo == "Y" && yesNo =="y") {
        lowerBoundary = guess;
      } else {
        upperBoundary = guess;
      }
      if (upperBoundary - lowerBoundary <= 2){
        Console.WriteLine("Your number is " + (lowerBoundary + 1));
      } else {
      StartGuess();
      }

    }
  }
}
