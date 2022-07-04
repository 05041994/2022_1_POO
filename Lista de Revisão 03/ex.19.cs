using System;

class Program {
  public static void Main() {


    for(int x = 1; x <= 10 ; x++){
      Console.WriteLine($"Tabuada do {x}");
      for(int t = 1; t <= 10; t++){
        int tabu = x * t;
        Console.WriteLine($"{x} X {t} = {tabu}");
      }
    }
  }
}
