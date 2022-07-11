using System;

class Program {
  public static void Main() {

    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine();
    string[] x = s.Split();

    foreach(string p in x){
      Console.Write(p[^1]);
    }
  }
}
