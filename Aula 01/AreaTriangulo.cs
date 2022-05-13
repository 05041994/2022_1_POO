using System;

public class Program {

  public static void Main(string[] args) {
    double b, h, a;
    Console.WriteLine("Me diga a base do triângulo");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine("Me diga a altura do triângulo");
    h = double.Parse(Console.ReadLine());
    a = b * h / 2;
    Console.WriteLine($"Àrea = {a:0.000}");
  }
}
