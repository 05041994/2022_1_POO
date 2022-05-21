using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite a base e a altura do retângulo:");
    
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    int area = a * b;
    int peri = 2 * (a + b);

    var s1 = Math.Pow(a , 2);
    var s2 = Math.Pow(b , 2);

    var s3 = s1 + s2;

    var final = Math.Sqrt(s3);

    Console.WriteLine($"Àrea = {area:0.00} - Perímetro = {peri:0.00} - Diagonal = {final:0.00}" );
   
  }
}
