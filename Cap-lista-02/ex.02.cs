using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe uma data no formato dd/mm/aaaa");
    string data = Console.ReadLine();
    string [] xs = data.Split('/');
    int dia = int.Parse(xs[0]);
    int mes = int.Parse(xs[1]);
    int ano = int.Parse(xs[2]);

    int nive = 2022 - ano;

    if(0 <= nive && nive <= 19) Console.WriteLine("Você está na faixa etária: Jovem");
    if(20 <= nive && nive <= 59) Console.WriteLine("Você está na faixa etária: adulto");
    if(60 <= nive) Console.WriteLine("Você está na faixa etária: Idoso");
    
  }
}
