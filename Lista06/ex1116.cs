using System;

  public class Program{
    
    public static void Main(string[] args){
    
    int inicial = int.Parse(Console.ReadLine());

    for(int x = 1; x <= inicial; x++){
      string comeco = Console.ReadLine();    
      string[] x1 = comeco.Split(' ');
      var pri = int.Parse(x1[0]);
      var sen = double.Parse(x1[1]);
      if(sen == 0){
        Console.WriteLine("divisao impossivel");
      }
      else{
        var div = pri / sen;
        Console.WriteLine($"{div:0.0}");
      }      
    }
  }
}
