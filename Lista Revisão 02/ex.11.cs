using System;

  public class Program{
    
    public static void Main(string[] args){

    string m1;
  
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string ano = Console.ReadLine(); 
    
    string[] data = ano.Split('/');

    int dd = int.Parse(data[0]);
    int mm = int.Parse(data[1]);
    int aa = int.Parse(data[2]);

    switch (mm) {    
      case 1: Console.WriteLine("A data é {0} de Janeiro {1}",dd , aa) ; break;
      case 2: Console.WriteLine("A data é {0} de Fevereiro {1}",dd , aa) ; break;
      case 3: Console.WriteLine("A data é {0} de Março {1}",dd , aa) ; break;
      case 4: Console.WriteLine("A data é {0} de Abril {1}",dd , aa) ; break;
      case 5: Console.WriteLine("A data é {0} de maio {1}",dd , aa) ; break;
      case 6: Console.WriteLine("A data é {0} de Junho {1}",dd , aa) ; break;
      case 7: Console.WriteLine("A data é {0} de Julho {1}",dd , aa) ; break;
      case 8: Console.WriteLine("A data é {0} de Agosto {1}",dd , aa) ; break;
      case 9: Console.WriteLine("A data é {0} de Setembro {1}",dd , aa) ; break;
      case 10: Console.WriteLine("A data é {0} de Outubro {1}",dd , aa) ; break;
      case 11: Console.WriteLine("A data é {0} de Novembro {1}",dd , aa) ; break;
      case 12: Console.WriteLine("A data é {0} de Dezembro {1}",dd , aa) ; break;
    }

      
  }
}
