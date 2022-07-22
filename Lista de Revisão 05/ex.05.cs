using System;

class Program {
  public static void Main() {
    double a,l,p;
    Console.WriteLine("altura em metros");
    a = double.Parse(Console.ReadLine());
    Console.WriteLine("largura em metros");
    l = double.Parse(Console.ReadLine());
    Console.WriteLine("profundidade em metros");
    p = double.Parse(Console.ReadLine());
    Console.WriteLine(VolumeLitros(a,l,p));
  }
  public static double VolumeLitros(double h, double l, double p){
    double a = h * l * p;
    return a;
  }
}
