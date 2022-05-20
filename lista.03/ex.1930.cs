using System;

public class Program {

  public static void Main(string[] args) {

    string x1 = Console.ReadLine();
    
    string[] a = x1.Split(' ');

    int c1 = int.Parse(a[0]);
    int c2 = int.Parse(a[1]);
    int c3 = int.Parse(a[2]);
    int c4 = int.Parse(a[3]);

    int res1 = c1 - 1;
    int res2 = c2 - 1;
    int res3 = c3 - 1;
    int res4 = c4 - 1;

    int total = res1 + res2 + res3 + res4 + 1;

    Console.WriteLine(total);
    
  }
}
