using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite um numero");
    int x = int.Parse(Console.ReadLine());
    AntecessorSucessor(x, out int x1, out int x2);
    Console.WriteLine(x1);
    Console.WriteLine(x2);
  }
  public static void AntecessorSucessor (int x, out int antecessor, out int sucessor){
    antecessor = x - 1;
    sucessor = x + 1;
  }
}
