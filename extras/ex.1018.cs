using System;

  public class Program{
    
    public static void Main(string[] args){
      int x, y100, y50, y20, y10, y5, y2, y1;
      x = y100 = y50 = y20 = y10 = y5 = y2 = y1 = 0;
      
      x = int.Parse(Console.ReadLine());

      Console.WriteLine(x);
      while (100 <= x){
        y100 +=1;
        x -=100;
      }
      while (50 <= x){
        y50 +=1;
        x -= 50;
      }
      while (20 <= x){
        y20 +=1;
        x -= 20;
      }
      while (10 <= x){
        y10 +=1;
        x -=10;
      }
      while (5 <= x){
        y5 +=1;
        x -=5;
      }
      while (2 <= x){
        y2 +=1;
        x -=2;
      }
      while (1 <= x){
        y1 +=1;
        x -=1;        
      }
      Console.WriteLine($"{y100} nota(s) de R$ 100,00");
      Console.WriteLine($"{y50} nota(s) de R$ 50,00");
      Console.WriteLine($"{y20} nota(s) de R$ 20,00");
      Console.WriteLine($"{y10} nota(s) de R$ 10,00");
      Console.WriteLine($"{y5} nota(s) de R$ 5,00");
      Console.WriteLine($"{y2} nota(s) de R$ 2,00");
      Console.WriteLine($"{y1} nota(s) de R$ 1,00");
  }
}
