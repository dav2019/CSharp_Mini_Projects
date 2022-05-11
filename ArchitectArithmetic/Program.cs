using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Console.WriteLine(rectangle(4, 5));
      // Console.WriteLine(circle(4));
      // Console.WriteLine(triangle(10, 9));
      double teotihuacan = triangle(750, 500) + rectangle(1500, 2500) + circle(375) * 0.5;
      // Console.WriteLine(teotihuacan);
      double cost = Math.Round(teotihuacan * 180, 2);
      // Console.WriteLine(cost);
      Console.WriteLine("The total cost flooring material for Mexico Teotihuacan is $" + cost + " pesos!");
    }
    static double rectangle(double length, double width) {
      return length * width;
    }
    static double circle(double radius) {
      return Math.PI * Math.Pow(radius, 2);
    }
    static double triangle(double bottom, double height) {
      return 0.5 * bottom * height;
    }

  }
}
