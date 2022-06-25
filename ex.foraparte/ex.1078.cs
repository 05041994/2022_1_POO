using System;

  public class Program{
    
    public static void Main(string[] args){
    
    int x,x1;

    x = int.Parse(Console.ReadLine());

    for(int y = 1; y <= 10; y++){
      x1 = x * y;
      Console.WriteLine($"{y:0} x {x:0} = {x1:0}");
    }
  }
}
