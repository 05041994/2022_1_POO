using System;

class Program {
  public static void Main() {

    Console.WriteLine("Resualdo:");
    int x = int.Parse(Console.ReadLine());
    for(int v = 10; x <= v; x++){
      Console.Write(x + " ");
      for(int d = 2; x >= d; d+=2){
        Console.Write(d + " ");
      }
      Console.WriteLine();
    }
  }
}
