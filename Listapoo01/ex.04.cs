using System;

class Program {
  public static void Main() {
    Cinema x = new Cinema();
    Console.WriteLine("Que dia você foi as cinema:");
    x.dia = Console.ReadLine();
    Console.WriteLine("Que horas você foi ao cinema");
    x.horario = int.Parse(Console.ReadLine());
    Console.WriteLine($"O valor a ser se for inteira R$ {x.Preço()} Reais");
    Console.WriteLine("O valor a ser se for meia-entrada é R$" + x.Preço() / 2 + "Reais");
  }
}
class Cinema{
  public string dia;
  public int horario;
  public double Preço(){
    double acrescimo = 1.50;
    double valor = 0;
    if( dia == "Seg" || dia == "Terça" || dia == "Quinta"){
      if(horario >= 17){
        valor = 16.00 * acrescimo;
      }
      else{
        valor = 16.00;
      }
    }
    if( dia == "Quarta"){
      valor = 8.00;
    }
    else{
      if(horario >= 17){
        valor = 20.00 * acrescimo;
      }
      else{
        valor = 20.00;
      }
    }
    return valor;
  }
}
