using System;

  public class Program{
    
    public static void Main(string[] args){
    int maior, posi;
    maior = posi = 0;
    for(int x =1 ; x <=100 ; x++){
      int y = int.Parse(Console.ReadLine());
      if( y >= maior){
        maior = y;
        posi = x;
      }
    }
    Console.WriteLine(maior);
    Console.WriteLine(posi);
  }
}
