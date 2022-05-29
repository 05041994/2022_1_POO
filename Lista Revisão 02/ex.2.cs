using System;

class Program {
  public static void Main() {
    int n1,n2,n3,n4,media;
    n1 = n2 = n3 = n4 = 0;

    Console.WriteLine("Digite quatro valores inteiros");
    n1 = int.Parse(Console.ReadLine());
    n2 = int.Parse(Console.ReadLine());
    n3 = int.Parse(Console.ReadLine());
    n4 = int.Parse(Console.ReadLine());
    media = (n1 + n2 + n3 + n4) / 4;
    Console.WriteLine("Média = " + media);
    Console.WriteLine("Números menores que a média");
    if (media > n1){
      Console.WriteLine(n1);
    }
    if (media > n2){
      Console.WriteLine(n2);
    }
    if (media > n3){
      Console.WriteLine(n3);
    }
    if (media > n4){
      Console.WriteLine(n4);
    }
    Console.WriteLine("Números maiores ou iguais à média");
    if (media <= n1){
      Console.WriteLine(n1);
    }
    if (media <= n2){
      Console.WriteLine(n2);
    }
    if (media <= n3){
      Console.WriteLine(n3);
    }
    if (media <= n4){
      Console.WriteLine(n4);
    }
            
  }
}
    
// Eu não soube um jeito de colocar eles em forma decrescente
