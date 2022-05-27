using System;

public class Program {

  static void Main(string[] args) {


    Console.WriteLine("Digite dois valores inteiros:");
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine("Maior:" + n1);
    }
    else
    {
        if (n1 == n2)
        {
            Console.WriteLine("valores iguais");
        }
        else
        {
            Console.WriteLine("Maior:" + n2);
        }         
    }
  }
}
