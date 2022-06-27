using System;

class Program {
  public static void Main() {
    int x1,x2;

    x1 = int.Parse(Console.ReadLine());
    x2 = int.Parse(Console.ReadLine());
    
    Console.WriteLine(Media(x1,x2));
    
  }
 public static string Media(int x, int y) {
   
    double m = (x + y) / 2;
    if(m >= 60){
      return "Aprovador";
    }
    else{
      return "Não aprovador";
    } 
  }
}
