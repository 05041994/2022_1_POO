using System;

class Program {
  public static void Main() {
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double b1 = double.Parse(Console.ReadLine());
    double c = Program.Maior(a, b, b1);
    Console.WriteLine(c);
  }
  public static double Maior(double x, double y, double y1) {
    if (x > y && x > y1) return x;
    else if(y > x && y > y1) return y;
    else return y1;
  }
}
