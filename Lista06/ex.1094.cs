using System;

  public class Program{
    
    public static void Main(string[] args){
    
      int x,total1,total2,total3,soma;  // Inicial
      x = total1 = total2 = total3 = soma = 0;
      double p1,p2,p3;
      x = int.Parse(Console.ReadLine());

      for(int x1 = 1; x1 <=x ; x1++){
        string x2 = Console.ReadLine();
        string[] v = x2.Split(' ');
        int v1 = int.Parse(v[0]);   //Numero
        char v2 = char.Parse(v[1]);  //Letra
        if(1 <= v1 && v1 <= 15){
          if(v2 == 'C'){
          total1 += v1; //soma
          }
          else if(v2 == 'R'){
          total2 += v1;          
          }
          else{
          total3 += v1;
          }        
        }
      }
  soma = total1 + total2 + total3;
  p1 = 
  p2 = 
  p3 = 
  Console.WriteLine($"Total: {soma:0} cobaias");  
  Console.WriteLine($"Total de coelhos: {total1:0}");
  Console.WriteLine($"Total de ratos: {total2:0}");
  Console.WriteLine($"Total de sapos: {total3:0}");
  Console.WriteLine($"Percentual de coelhos: {p1:0.00} %");
  Console.WriteLine($"Percentual de ratos: {p2:0.00} %");
  Console.WriteLine($"Percentual de sapos: {p3:0.00} %");
  }
}
// Não sei fazer porcentagem...
