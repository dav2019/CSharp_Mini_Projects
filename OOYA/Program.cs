using System;

namespace OOYA
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
      sam.SetHobbies(new string[] {
        "Movies",
        "Tennis",
        "Mountain biking"
      });
      Console.WriteLine(sam.ViewProfile());
    }
  }
}
