using System;

class Program {
  public static void Main() {

    Console.WriteLine("Digite uma frase:");
    string palavra = Console.ReadLine();
    string[] x = palavra.Split(' ');
    foreach (var y in x){
      Console.Write(y.Length);
    }
  }
}
