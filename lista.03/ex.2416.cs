using System;

public class Program {

  public static void Main(string[] args) {

    string x1 = Console.ReadLine();
    
    string[] a = x1.Split(' ');

    int c1 = int.Parse(a[0]);
    int c2 = int.Parse(a[1]);

    int resto = c1 % c2;
    Console.WriteLine(resto);
  }
}
