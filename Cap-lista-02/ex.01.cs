using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe uma data no formato dd/mm/aaaa");
    string data = Console.ReadLine();
    string [] xs = data.Split('/');
    int dia = int.Parse(xs[0]);
    int mes = int.Parse(xs[1]);
    int ano = int.Parse(xs[2]);

    if(1 <= dia && dia >=30 || 1 <= mes && mes >=12){
      Console.WriteLine("Data não existente");
    }
    int vc = 2022 - ano;
    Console.WriteLine($" no final de {ano}, você terá {vc} anos");
    
  }
}
