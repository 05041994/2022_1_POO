using System;

public class Program {

  public static void Main(string[] args) {
    const double pi = 3.14159;
    const double y = (4.0/3);
    var r = double.Parse(Console.ReadLine());
    var numero = 3;
    double x1 = Math.Pow(r, numero);
    double k1 = y * pi * x1;
    Console.WriteLine($"VOLUME = {k1:0.000}");
  }
}
