using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe uma data no formato dd/mm/aaaa");
    string data = Console.ReadLine();
    string [] xs = data.Split('/');
    int dia = int.Parse(xs[0]);
    int mes = int.Parse(xs[1]);
    int ano = int.Parse(xs[2]);

    switch(mes)
    {
      case 1: Console.WriteLine("Você nasceu no mes janeiro"); break;
      case 2: Console.WriteLine("Você nasceu no mes fevereiro"); break;
      case 3: Console.WriteLine("Você nasceu no mes março"); break;
      case 4: Console.WriteLine("Você nasceu no mes Abril"); break;
      case 5: Console.WriteLine("Você nasceu no mes Maio"); break;
      case 6: Console.WriteLine("Você nasceu no mes Junho"); break;
      case 7: Console.WriteLine("Você nasceu no mes julho"); break;
      case 8: Console.WriteLine("Você nasceu no mes Agosto"); break;
      case 9: Console.WriteLine("Você nasceu no mes Setembro"); break;
      case 10: Console.WriteLine("Você nasceu no mes outubro"); break;
      case 11: Console.WriteLine("Você nasceu no mes Novembro"); break;
      case 12: Console.WriteLine("Você nasceu no mes Dezembro"); break;
      default: Console.WriteLine("Més não encontrado"); break;
    }
  }
}
