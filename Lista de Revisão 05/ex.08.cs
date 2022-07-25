using System;

class Program {
  public static void Main() {
    Console.WriteLine("Me diga um valor inteiro");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine(MenorInteiro(x));
  }
  public static int MenorInteiro(double x){
    int x1 = (int) x;
    if(x<=x1) return x1;
    else return x1 + 1;
    
  }
}
