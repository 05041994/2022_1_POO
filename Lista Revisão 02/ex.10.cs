using System;

  public class Program{
    
    public static void Main(string[] args){

    int d1 ;
    d1 = 0 ;
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string ano = Console.ReadLine(); 
    
    string[] data = ano.Split('/');

    int dd = int.Parse(data[0]);
    int mm = int.Parse(data[1]);
    int aa = int.Parse(data[2]);

      switch (mm) {    
      case 1:d1 =31  ; break;
      case 2:d1 = 28; break;
      case 3:d1 = 31; break;
      case 4:d1 = 30 ; break;
      case 5:d1 = 31; break;
      case 6:d1 = 30; break;
      case 7:d1 = 31; break;
      case 8:d1 = 30; break;
      case 9:d1 = 31; break;
      case 10:d1 = 30; break;
      case 11:d1 = 31; break;
      case 12:d1 = 30 ; break;
      default: d1 = d1; break;
    }
    
    if ((1 <= dd && dd <= d1) && (1 <= mm && mm <= 12) && (1900 <= aa && aa <= 2100)){
      Console.Write("A data informada é válida");
    }else{
      Console.WriteLine("A data informada não é válida");
    }

  }
}
