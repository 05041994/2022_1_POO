using System;

class Program {
  public static void Main() {
    int x1;
    for(int x = 1; x <= 30;x++){
      int t = x % 3;
      if(t == 0){
        x1 = x * -1;
        Console.Write(x1 + " ");
      }
      else{
        Console.Write(x + " ");
      }
    }
  }
}
