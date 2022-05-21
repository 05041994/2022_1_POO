using System;

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite o Seu Nome Completo:");
    string x1 = Console.ReadLine();
    
    string[] a = x1.Split(' ');
  
    Console.WriteLine("Bem-Vindo ao C#,"+ a[0]);
  
  }
}
