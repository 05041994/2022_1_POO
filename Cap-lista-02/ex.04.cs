using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite o nome e a data de nascimento da 1a pessoa:");
    string nome1 = Console.ReadLine();
    string data1 = Console.ReadLine();
    string [] xs1 = data1.Split('/');
    int dia1 = int.Parse(xs1[0]);
    int mes1 = int.Parse(xs1[1]);
    int ano1 = int.Parse(xs1[2]);

    Console.WriteLine("Digite o nome e a data de nascimento da 2a pessoa:");
    string nome2 = Console.ReadLine();
    string data2 = Console.ReadLine();
    string [] xs2 = data2.Split('/');
    int dia2 = int.Parse(xs2[0]);
    int mes2 = int.Parse(xs2[1]);
    int ano2 = int.Parse(xs2[2]);

    if(ano1 > ano2) Console.WriteLine($" {nome2} é o(a) mais novo(a)");
    if(ano2 > ano1) Console.WriteLine($" {nome1} é o(a) mais novo(a)");
    if(ano1 == ano2){
      if(mes1 > mes2) Console.WriteLine($" {nome2} é o(a) mais novo(a)");
      if(mes2 > mes1) Console.WriteLine($" {nome1} é o(a) mais novo(a)");
      if(mes1 == mes2 && dia1 > dia2) Console.WriteLine($" {nome2} é o(a) mais novo(a)");
      else Console.WriteLine($" {nome1} é o(a) mais novo(a)");
    }
    if( ano1 == ano2 && mes1 == mes2 && dia1 == dia2)
      Console.WriteLine($"{nome1} e {nome2} nasceram no mesmo dia");
  }
}
