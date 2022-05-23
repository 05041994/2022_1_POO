using System;

public class Program {

  public static void Main(string[] args) {

      
    string x1 = Console.ReadLine();

    string[] a = x1.Split(' ');

    int c1 = int.Parse(a[0]);
    int c2 = int.Parse(a[1]);

    if (0 <= c1 && c1 <= 432 && 0 <= c2 && c2 <= 468)
    {
      Console.WriteLine("dentro");
    }
    else{   
      Console.WriteLine("fora");
    }
    }
}
