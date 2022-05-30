using System;

  public class Program{
    
    public static void Main(string[] args){

      int x1,x2,x3;
      x1 = x2 = x3 = 0 ; 
      Console.WriteLine("Digite três valores:");
      x1 = int.Parse(Console.ReadLine());
      x2 = int.Parse(Console.ReadLine());
      x3 = int.Parse(Console.ReadLine());

      if(x1 <= x2 && x2 <= x3){
        Console.WriteLine($"{x1:0},{x2:0},{x3:0}");       
      } else if(x1 <= x3 && x3 <= x2){
        Console.WriteLine($"{x1:0},{x3:0},{x2:0}");
      } else if(x2 <= x1 && x1 <= x3){
        Console.WriteLine($"{x2:0},{x1:0},{x3:0}");
      } else if(x2 <= x3 && x3 <= x1){
        Console.WriteLine($"{x2:0},{x3:0},{x1:0}");
      } else if(x3 <= x2 && x2 <= x1){
        Console.WriteLine($"{x3:0},{x2:0},{x1:0}");
      } else{
        Console.WriteLine($"{x3:0},{x1:0},{x2:0}");
      }
  }
}
