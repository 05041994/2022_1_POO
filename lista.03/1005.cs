using System;

public class Program {
  public static void Main(string[] args) {
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = (((a * 3.5) + (b * 7.5)) / 11.0);   
   Console.WriteLine($"MEDIA = {c:0.00000}");
  }
}
