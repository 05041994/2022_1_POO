using System;

class Program {
  public static void Main() {
    double x, x1;
    Console.WriteLine("Digite dois valores: um em cada linha.");
    x = double.Parse(Console.ReadLine());
    x1 = double.Parse(Console.ReadLine());
    Console.WriteLine(Menor(x,x1));
  }
  public static double Menor(double y, double y1){
    if(y < y1)
      return y;
    else
      return y1;
  }
}
