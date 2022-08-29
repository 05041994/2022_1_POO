using System;

class Program {
  public static void Main() {
    Compra t = new Compra();
    Console.WriteLine("Qual foi o valor Total da sua comprar");
    t.SetTotal(double.Parse(Console.ReadLine()));
    Console.WriteLine("Qual foi o numero de prestacoes");
    t.SetPrestacoes(int.Parse(Console.ReadLine()));
    t.GetValorPrestacao();
    t.GetValorDesconto();
    Console.WriteLine($"Valor das parcelas {t.GetValorPrestacao():f2} R$");
    Console.WriteLine($"Valor com desconto de 15% de desconto {t.GetValorDesconto():f2} R$");
  }
}
class Compra{
  private double Total;
  private int numPrestacoes;
  public void SetTotal(double Total){
    if(Total > 0) this.Total = Total;
  }
  public void SetPrestacoes(int numPrestacoes){
    if(numPrestacoes > 0) this.numPrestacoes = numPrestacoes;
  }
  public double GetValorPrestacao(){
    double valorpresta = Total / numPrestacoes;
    return valorpresta;
  }
  public double GetValorDesconto(){
    double valorcomdesconto = Total - (Total * 0.15);
    return valorcomdesconto;
  }
}
