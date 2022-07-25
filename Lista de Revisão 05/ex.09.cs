using System;

class Program {
  public static void Main() {
    
    Console.WriteLine("Digite o inicio");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o fim");
    int x1 = int.Parse(Console.ReadLine());
    Console.WriteLine(Soma(x, x1));
  }
  public static int Soma(int inicio, int fim){

    int total = 0;
    while(inicio <= fim){
      total += inicio;
      inicio++;
    }
    return total;
  }
}
