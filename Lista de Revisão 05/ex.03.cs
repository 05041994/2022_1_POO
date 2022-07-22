using System;

class Program {
  public static void Main() {
    double x1,x2;
    Console.WriteLine("Me diga o raio do circulo");
    x1 = double.Parse(Console.ReadLine());
    x2 = double.Parse(Console.ReadLine());
    Console.WriteLine(Diagonal(x1,x2));

  }
  public static double Diagonal(double b, double h){
    double r = (b*b) + (h*h);
    double f = Math.Sqrt(r);
    return f;
  }
}
