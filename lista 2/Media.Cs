using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    int b = int.Parse(Console.ReadLine());
    // 2 e 3 são os pesos
    int c = (((a * 2) + (b * 3)) / 5);
    
    
   Console.WriteLine("Média parcial = "+ c);
  }
}
