using System;

class Program {
  public static void Main() {
    double x1;
    Console.WriteLine("Me diga o raio do circulo");
    x1 = double.Parse(Console.ReadLine());
    Console.WriteLine(VolumeEsfera(x1));

  }
  public static double VolumeEsfera(double r){
    double x = Math.Pow(r, 3);
    double pi4 = 4 * 3.1415;
    double final = (x * pi4) / 3;
    return final;
  }
}
