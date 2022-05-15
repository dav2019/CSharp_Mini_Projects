using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      // 1
      Console.Write("What is your secret message? ");
      string input = Console.ReadLine();
      // 2
      char[] secretMessage = input.ToCharArray();
      Console.WriteLine(secretMessage);
      // 3
      char[] encryptedMessage = new char[secretMessage.Length];
      // 4
      for (int i = 0; i < secretMessage.Length; i++) 
      {
        char letter = secretMessage[i];
        int letterPosition = Array.IndexOf(alphabet, letter);
        int newLetterPosition = (letterPosition + 3) % 26;
        char letterEncoded = alphabet[newLetterPosition];
        encryptedMessage[i] = letterEncoded;
      }
      string encodedString = String.Join("", encryptedMessage);
      Console.WriteLine($"Your encoded message is: {encodedString}");
    }
  }
}
