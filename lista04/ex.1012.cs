using System;

public class Program {

  public static void Main(string[] args) {
    const double pi = 3.14159;
    string x1 = Console.ReadLine();
    
    string[] a = x1.Split(' ');

    double c1 = double.Parse(a[0]);
    double c2 = double.Parse(a[1]);
    double c3 = double.Parse(a[2]);

    double tri = (c1 * c3) / 2.0;
    var R = Math.Pow(c3, 2);
    double cir = R * pi;
    double tra = ((c1 + c2) /2.0) * c3;
    double qua = c2 * c2;
    double ret = c1 * c2;
    
    Console.WriteLine($"TRIANGULO: {tri:0.000}");
    Console.WriteLine($"CIRCULO: {cir:0.000}");
    Console.WriteLine($"TRAPEZIO: {tra:0.000}");
    Console.WriteLine($"QUADRADO: {qua:0.000}");
    Console.WriteLine($"RETANGULO: {ret:0.000}");
    
  }
}
