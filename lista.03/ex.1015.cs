using System;

public class Program {

  public static void Main(string[] args) {

    string x1 = Console.ReadLine();
    string x2 = Console.ReadLine();
    
    string[] a = x1.Split(' ');
    string[] b = x2.Split(' ');

    double c1 = double.Parse(a[0]);
    double c2 = double.Parse(a[1]);

    double b1 = double.Parse(b[0]);
    double b2 = double.Parse(b[1]);

    double soma1 = b1 - c1;
    double soma2 = b2 - c2;

    double s1 = Math.Pow(soma1, 2);
    double s2 = Math.Pow(soma2, 2);

    double s3 = s1 + s2;

    double final = Math.Sqrt(s3);

    

    Console.WriteLine($"{final:0.0000}");
  
  }
}
