using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite Uma Frase:");

    string s = Console.ReadLine();
    string [] v = s.Split();

    foreach(string p in v){
      int soma = 0;
      int x = 0;

      while(x < p.Length){
        if(p[x] == 'a' || p[x] == 'e' || p[x] == 'i' || p[x] == 'o' || p[x] == 'u'){
          soma++;
        }
        x++;
      }
      x = 0;
      while(x < soma){
        Console.Write(p + " ");
        x++;
      }
    }
  }
}
