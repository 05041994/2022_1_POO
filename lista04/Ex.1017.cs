using System;

public class Program {

  public static void Main(string[] args) {
    const double gasto = 12.0;
    int h, velo, x;
    h = int.Parse(Console.ReadLine());
    velo = int.Parse(Console.ReadLine());
    x = h * velo;
    double resu = x / gasto;
    Console.WriteLine($"{resu:0.000}");
  }
}
