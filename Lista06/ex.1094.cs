using System;

  public class Program{
    
    public static void Main(string[] args){
    
      int x; // Inicial
      x = int.Parse(Console.ReadLine());

      for(int x1 = 1; x1 <=x ; x1++){
        string x2 = Console.ReadLine();
        string[] v = x2.Split(' ');
        int v1 = int.Parse(v[0]);   //Numero
        char v2 = char.Parse(v[1]);  //Letra
        if(v2 == 'C'){
          int total1 = 0; total1 += v1; //soma
        }
        else if(v2 == 'R'){
          int total2 = 0; total2 += v1;          
        }
        else{
          int total3 = 0; total3 += v1;
        }        
      }
    Console.WriteLine($"Total de coelhos: {total1:0}");
    Console.WriteLine($"Total de ratos: {total2:0}");
    Console.WriteLine($"Total de sapos: {total3:0}");
  }
}
// ainda com erro, vou tira minhas duvidas no cap.
