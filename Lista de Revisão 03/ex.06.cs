using System;

class Program {
  public static void Main() {
    int conta = 0;
    int soma = 0;
    for(int x = 1; x <= 30; x++){
      Console.Write(x + " ");
      conta++;
      soma +=x;
      if(conta == 3){
        Console.Write(soma + " ");
        soma = 0;
        conta = 0;
      }
    }
  }
}
