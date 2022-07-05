using System;

class Program {
  public static void Main() {
    int x1;
    for(int x = 1; x <= 10;x++){
      int t = x % 2;
      if(t == 1){
        x1 = x ;
        Console.Write(x1 + " ");
      }
      else if( t == 0){
        x1 = x * -1;
        Console.Write(x1 + " ");
      }      
    }
  }
}
