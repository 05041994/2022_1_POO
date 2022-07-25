using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase e eu farei uma senha para você:");
    string p = Console.ReadLine();
    Console.WriteLine("Senha = "+Senha(p)+".");

  }
  public static string Senha(string texto){
    string[] x = texto.Split(' ');
    string k = "";
    foreach (var y in x){
      var u = y.Length;
      k += u.ToString();
    }
    return k;
  }
}
