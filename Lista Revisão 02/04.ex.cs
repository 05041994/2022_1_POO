using System;

  public class Program{
    
    public static void Main(string[] args){
      int x1,x2 ;
      x1 = x2 = 0;

  
      Console.WriteLine("Digite o primeiro horário no formato hh:mm");
      string data1 = Console.ReadLine(); 
    
      string[] data01 = data1.Split(':');

      int hora1 = int.Parse(data01[0]);
      int min1 = int.Parse(data01[1]);

      Console.WriteLine("Digite o segundo horário no formato hh:mm");
      string data2 = Console.ReadLine(); 
    
      string[] data02 = data2.Split(':');

      int hora2 = int.Parse(data02[0]);
      int min2 = int.Parse(data02[1]);
    
      int hora3 = hora1 + hora2;
      int soma01 = min1 + min2;

      if(60 <= soma01){
        x1 = soma01 - 60;
        x2 = hora3 + 1;
      }
      else{
        x1 = soma01;
        x2 = hora3;
      }

    Console.WriteLine($"{x2:00}:{x1:0}");
      
  }
}
