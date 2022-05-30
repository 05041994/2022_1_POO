using System;

  public class Program{
    
    public static void Main(string[] args){
      int hh, mm;
      hh = mm = 0;
	
			Console.WriteLine ("Digite o horário no formato hh:mm");
      string horario = Console.ReadLine(); 


      
			string[] hora = horario.Split(':');
			hh = int.Parse (hora [0]) % 12;
			mm = int.Parse (hora [1]) % 60;

      if((mm => 60) || (hh => 24)){ // codigo erra nesta linha
        Console.WriteLine("Hora Inválida");
      }
    	int anguloA = mm * 6;										
			int anguloB = ((hh * 60) + mm) / 2;							 
			int diferença = anguloA - anguloB;

      Console.WriteLine ("Menor ângulo entre os ponteiros " + diferença + " graus");

    
  }
}
