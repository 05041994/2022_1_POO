using System;

  public class Program{
    
    public static void Main(string[] args){

      double valor;
      int contador;
      double total, media;
      valor = total = media = 0;
      contador = 0;
      for(int x = 1; x <= 6; x++){
        
        valor = double.Parse(Console.ReadLine());

        if(valor > 0){
          contador +=1;
          total += valor;
        }        
      }
      media = total / contador;
      Console.WriteLine($"{contador} valores positivos");
        Console.WriteLine($"{media:0.0}");
  }
}
