using System;

class Program {
  public static void Main() {

    Circulo t = new Circulo();
    Console.WriteLine("Digite o raio do seu circulo");
    t.Setraio(double.Parse(Console.ReadLine()));
    Console.WriteLine($"A sua Area sera de {t.Calarea()}");
    Console.WriteLine($"A sua Circuferencia sera de {t.CalCircu()}");
  }
}
class Circulo{
  private double raio;
  public void Setraio(double v){
    if(v > 0) raio = v;   
  }
    public double Getraio(){
    return raio;
  }
  public double Calarea(){
    double area = Math.PI * (raio*raio);
    return area;
  }
  public double CalCircu(){
    double circu = 2 * Math.PI * raio;
    return circu;
  }
}
