using System;

class Program {
  public static void Main() {
    int contar = 0;
    Console.WriteLine("Digite uma frase:");
    string palavra = Console.ReadLine();
    string[] x = palavra.Split(' ');

foreach (var y in x)
{
  contar++;
}  
  Console.WriteLine(contar);
  }
}
