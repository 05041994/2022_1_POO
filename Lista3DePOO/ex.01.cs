using System;

class Program {
  public static void Main() {
    IMC t = new IMC();
    Console.WriteLine("Digite o seu peso");
    t.SetPeso(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite a sua altura");
    t.SetAltura(double.Parse(Console.ReadLine()));
    Console.WriteLine($"O seu IMC é de {t.CalcIMC()}");
  }
}
class IMC{
  private double Peso,Altura;
  public void SetPeso(double v){
    if(v > 0) Peso = v;
  }
  public double GetPeso(){
    return Peso;
  }
  public void SetAltura(double v){
    if(v > 0) Altura = v;
  }
  public double GetAltura(){
    return Altura;
  }
  public double CalcIMC(){
    double icm = Peso / (Altura * Altura);
    return icm;
    
  }
}
