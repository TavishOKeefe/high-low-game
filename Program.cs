using System;
using System.Collections.Generic;

namespace HiLow {

  public class Program
  {
    static void Main(){
      Console.WriteLine("");
      Console.WriteLine("----------");
      Console.WriteLine("Welcome! I'm a computer and I'd love to guess what number you're thinking of.");
      Guess start = new Guess();
      start.StartGuess();
    }
  }
}
