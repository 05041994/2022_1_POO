using System;

class Program {
  public static void Main() {
    Notas x = new Notas();
    Console.WriteLine("Digite as suas notas:");
    x.n1 = int.Parse(Console.ReadLine());
    x.n2 = int.Parse(Console.ReadLine());
    x.n3 = int.Parse(Console.ReadLine());
    x.n4 = int.Parse(Console.ReadLine());

    if (x.aprovado() == true)
      Console.WriteLine("Você foi aprovado");
    else{
      Console.WriteLine("Digite a nota da sua prova final");
      x.ProvaFinal = int.Parse(Console.ReadLine());
      if (x.aprovado() == false)
        Console.WriteLine("Você foi reprovado");
      else{
        Console.WriteLine("Você foi aprovado");
      }
    }
  }
}

class Notas{
  public int n1, n2, n3, n4, ProvaFinal;
  public bool aprovado(){
    if (MediaP() >= 60){
      return true;
    }
    else {
      int media = (MediaP() + ProvaFinal) / 2; 
      return media >= 60;
    }
  }
  public int MediaP(){
    int media = (n1 * 2 + n2 * 2 + n3 * 3 + n4 * 3) / 10;
    return media;
  }
  public int MediaF(){
    int media = MediaP();
    if (media < 60)
      media = (MediaP() + ProvaFinal) / 2;
    return media;
  }
}
