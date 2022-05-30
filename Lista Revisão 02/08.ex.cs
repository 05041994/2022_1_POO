using System;

  public class Program{
    
    public static void Main(string[] args){

      int x1,x2,x3,x4;
      x1 = x2 = x3 = x4 = 0 ; 
      Console.WriteLine("Digite quatro valores:");
      x1 = int.Parse(Console.ReadLine());
      x2 = int.Parse(Console.ReadLine());
      x3 = int.Parse(Console.ReadLine());
      x4 = int.Parse(Console.ReadLine());

      
      if(x1 == x2 && x2 == x3 && x3 == x4){
        Console.WriteLine("erro");
      }
      else if(x1 <= x2 && x2 <= x3 && x3 <= x4){
        Console.WriteLine($"O maior numero é = {x4:0}");
        Console.WriteLine($"O menor numero é = {x1:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x2 + x3));     
      } else if(x2 <= x1 && x1 <= x3 && x3 <= x4){
        Console.WriteLine($"O maior numero é = {x4:0}");
        Console.WriteLine($"O menor numero é = {x2:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x3 + x1));         
      } else if(x3 <= x2 && x2 <= x1 && x1 <= x4){
        Console.WriteLine($"O maior numero é = {x4:0}");
        Console.WriteLine($"O menor numero é = {x3:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x2 + x1));        
      } else if(x4 <= x3 && x3 <= x2 && x2 <= x1){
        Console.WriteLine($"O maior numero é = {x1:0}");
        Console.WriteLine($"O menor numero é = {x4:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x2 + x3));
      } else if(x4 <= x3 && x3 <= x1 && x1 <= x2){
        Console.WriteLine($"O maior numero é = {x2:0}");
        Console.WriteLine($"O menor numero é = {x4:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x3 + x1));        
      } else if(x4 <= x1 && x1 <= x2 && x2 <= x3){
        Console.WriteLine($"O maior numero é = {x3:0}");
        Console.WriteLine($"O menor numero é = {x4:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x2 + x3));
      } else if(x2 <= x4 && x4 <= x3 && x3 <= x1){
        Console.WriteLine($"O maior numero é = {x1:0}");
        Console.WriteLine($"O menor numero é = {x2:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x4 + x3));
      } else if(x3 <= x2 && x2 <= x4 && x4 <= x1){
        Console.WriteLine($"O maior numero é = {x1:0}");
        Console.WriteLine($"O menor numero é = {x3:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x2 + x4));
      } else if(x3 <= x4 && x4 <= x1 && x1 <= x2){
        Console.WriteLine($"O maior numero é = {x2:0}");
        Console.WriteLine($"O menor numero é = {x3:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x4 + x1));
      } else if(x3 <= x1 && x1 <= x2 && x2 <= x4){
        Console.WriteLine($"O maior numero é = {x4:0}");
        Console.WriteLine($"O menor numero é = {x3:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x1 + x2));
      } else if(x2 <= x3 && x3 <= x1 && x1 <= x4){
        Console.WriteLine($"O maior numero é = {x4:0}");
        Console.WriteLine($"O menor numero é = {x2:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x3 + x1));
      } else if(x4 <= x2 && x2 <= x1 && x1 <= x3){
        Console.WriteLine($"O maior numero é = {x3:0}");
        Console.WriteLine($"O menor numero é = {x4:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x2 + x1));
      } else if(x4 <= x2 && x2 <= x3 && x3 <= x1 ){
        Console.WriteLine($"O maior numero é = {x1:0}");
        Console.WriteLine($"O menor numero é = {x4:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x2 + x3));
      } else if(x2 <= x3 && x3 <= x4 && x4 <= x1){
        Console.WriteLine($"O maior numero é = {x1:0}");
        Console.WriteLine($"O menor numero é = {x2:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x3 + x4));
      } else if(x3 <= x4 && x4 <= x2 && x2 <= x1){
        Console.WriteLine($"O maior numero é = {x1:0}");
        Console.WriteLine($"O menor numero é = {x3:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x4 + x2));
      } else if(x4 <= x1 && x1 <= x3 && x3 <= x2){
        Console.WriteLine($"O maior numero é = {x2:0}");
        Console.WriteLine($"O menor numero é = {x4:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x1 + x3));
      } else if(x1 <= x4 && x4 <= x3 && x3 <= x2){
        Console.WriteLine($"O maior numero é = {x2:0}");
        Console.WriteLine($"O menor numero é = {x1:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x4 + x3));
      } else if(x1 <= x2 && x2 <= x4 && x4 <= x3){
        Console.WriteLine($"O maior numero é = {x3:0}");
        Console.WriteLine($"O menor numero é = {x1:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x2 + x4));
      } else if(x2 <= x4 && x4 <= x1 && x1 <= x3){
        Console.WriteLine($"O maior numero é = {x3:0}");
        Console.WriteLine($"O menor numero é = {x2:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x4 + x1));
      } else if(x1 <= x4 && x4 <= x2 && x2 <= x3){
        Console.WriteLine($"O maior numero é = {x3:0}");
        Console.WriteLine($"O menor numero é = {x1:0}");
        Console.WriteLine("A soma do segundo maior valor com o segundo menor = " + (x4 + x2));
      }

  }
}
