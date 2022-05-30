using System;

  public class Program{
    
    public static void Main(string[] args){
      double ax, bx,c, delta;
      ax = bx = c = delta = 0;

      Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau");
      ax = double.Parse(Console.ReadLine());
      bx = double.Parse(Console.ReadLine());
      c = double.Parse(Console.ReadLine());

      delta = bx * bx - 4 * ax * c;

      double r1 = (-bx + Math.Sqrt(delta)) / (2 * ax);
      double r2 = (-bx - Math.Sqrt(delta)) / (2 * ax);

      if (delta < 0 || ax == 0){
      Console.WriteLine("Impossivel calcular");
      }
      else {
      Console.WriteLine($"As raízes são {r1:0} e {r2:0}");

    }      
  }
}
