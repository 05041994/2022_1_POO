using System;

  public class Program{
    
    public static void Main(string[] args){

      int x, x1, xv;
      x = x1 = xv = 0;

      x = int.Parse(Console.ReadLine());

      for(int y = 1; y <= x; y++){
        x1 = int.Parse(Console.ReadLine());

        xv = x1 % 2;

        if(x1 == 0){
          Console.WriteLine("NULL");
        }
        else if( xv == 0 ){
          if(x1 >= 1){
            Console.WriteLine("EVEN POSITIVE");
          }
          else if (x1 <= -1){
            Console.WriteLine("EVEN NEGATIVE");
          }
          }
        else if(xv != 0){
          if(x1 >= 1){
            Console.WriteLine("ODD POSITIVE");
          }
          else if( x1 <= -1){
            Console.WriteLine("ODD NEGATIVE");
          }
        }      
    }
  }
}
