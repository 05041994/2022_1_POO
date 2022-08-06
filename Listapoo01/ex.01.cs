using System;

class Program {
  public static void Main() {
    Círculo t = new Círculo();
    Console.WriteLine("Digite o raio do Círculo");
    t.raio = double.Parse(Console.ReadLine());
    Console.WriteLine($"A area do Circulo é igual a {t.Calcarea()}");
    
  }
}
class Círculo{
  public double raio;
  public double Calcarea(){
    double circunferencia = (3.14 * 2) * raio;
    return circunferencia;
  }
}
