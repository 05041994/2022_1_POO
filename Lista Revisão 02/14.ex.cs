using System;

  public class Program{
    
    public static void Main(string[] args){
      int x1,x2,x3;
      x1 = x2 = x3 = 0;
      
      Console.WriteLine("Digite tres valores:");
      
      x1 = int.Parse(Console.ReadLine());
      x2 = int.Parse(Console.ReadLine());
      x3 = int.Parse(Console.ReadLine());

      if( x1 + x2 > x3){
        if(x1 == x2 && x2 == x3){
        Console.WriteLine("Esse triângulo é equilátero");
      } else if(x1 != x2 && x2 != x3 && x3 != x1){
        Console.WriteLine("Esse triângulo é escaleno");
      } else{
        Console.WriteLine("Esse triângulo é isósceles");
      }
      }
      else if( x1 + x2 < x3){
        Console.WriteLine("Esses valores não formam um triângulo  
");
      }   
  }
}
