using System;

  public class Program{
    
    public static void Main(string[] args){
      int hh, mm;
      hh = mm = 0;
	
			Console.WriteLine ("Digite o horário no formato hh:mm");
      string horario = Console.ReadLine(); 


      
			string[] hora = horario.Split(':');
			hh = int.Parse (hora [0]) ;
			mm = int.Parse (hora [1]) ;

      int anguloA = (mm % 60) * 6;										
			int anguloB = (((hh % 12)* 60) + mm) / 2;

      int diferença = anguloA - anguloB;

      if(mm => 60 || 24 <= hh){ 
        Console.WriteLine("Hora Inválida");
      }
			else{
              Console.WriteLine ("Menor ângulo entre os ponteiros " + diferença + " graus");
        
    }				 
  }
}
// Eu to conseguingo fazer melhor que isso e ta dando erro na linha 23. 
