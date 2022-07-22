using System;

class Program {
  public static void Main() {
  double x1;
    Console.WriteLine("Me diga o raio do circulo");
    x1 = double.Parse(Console.ReadLine());
    Console.WriteLine(AreaCirculo(x1));

  }
  public static double AreaCirculo(double raio){
    return (raio * raio) * 3.1415;
  }
}
