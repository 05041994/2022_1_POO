using System;

class Program {
  public static void Main() {
    double x,x1;
    Console.WriteLine("Qual é o peso da sua produto em kg:");
    x = double.Parse(Console.ReadLine());
    Console.WriteLine("Qual é a distancia em Km:");
    x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("O falor do frente sera de : " + Frete(x,x1));
  }
  public static double Frete(double massa, double distancia){
    double x = massa * 0.01;
    double f = x * distancia;
    return f;
  }
}
