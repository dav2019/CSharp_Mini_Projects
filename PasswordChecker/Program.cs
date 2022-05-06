using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "~!@#$%^&*-+";
      
      // Capture User Input
      Console.WriteLine("Enter a password: ");
      string password = Console.ReadLine();
      
      // Score the user's password
      int score = 0;

      // if statement for minimum length
      if (password.Length >= minLength) {
        score ++;
      }
      // if statement for uppercase
      if (Tools.Contains(password, uppercase)) {
        score++;
      }
      // if statement for lowercase
      if (Tools.Contains(password, lowercase)) {
        score++;
      }
      // if statement for digits
      if (Tools.Contains(password, digits)) {
        score++;
      }
      // if statement for special characters
      if (Tools.Contains(password, specialChars)) {
        score++;
      }
      // Console.WriteLine(score);
      // if statement for password = 1234
      if (password == "1234") {
        score = 0;
      }
      Console.WriteLine(score);
      // Case statement for password's score
      switch (score) {
        case 0:
          Console.WriteLine("Password doesn't meet any of the standards!");
          break;
        case 1:
          Console.WriteLine("Password is weak!");
          break;
        case 2:
          Console.WriteLine("Password is medium!");
          break;
        case 3:
          Console.WriteLine("Password is strong!");
          break;
        case 4:
        case 5:
          Console.WriteLine("Password is extremely strong!");
          break;
      }
    }
  }
}
