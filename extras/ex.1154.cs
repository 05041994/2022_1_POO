using System;

  public class Program{
    
    public static void Main(string[] args){
      int idade, contador, y;
      double media, fim;
      fim = media = 0;
      contador = y = 0;
    for(int x = 0; x <= y; x++ ){
      y ++;
      idade = int.Parse(Console.ReadLine());
      if(idade < 0 ){
        break;
      }
      else{
        contador +=1;
        media += idade;
      }
    }
    fim = media / contador;
    Console.WriteLine($"{fim:0.00}");
  }
}
