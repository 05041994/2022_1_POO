using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite um texto");
    string s = Console.ReadLine();
    int i = 1;
    while (i <= s.Length) {
      Console.WriteLine($"{i:0} - {s}");
      i++;
    }
  }
}
