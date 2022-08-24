using System;

class Program {
  public static void Main() {
    Notas t = new Notas();
//    Console.WriteLine("Digite o seu nome");
//    t.SetNome(Console.ReadLine());
    Console.WriteLine("Digite as suas notas");
    t.Setn1(int.Parse(Console.ReadLine()));
    t.Setn2(int.Parse(Console.ReadLine()));
    t.Setn3(int.Parse(Console.ReadLine()));
    t.Setn4(int.Parse(Console.ReadLine()));
    
    if(t.MediaP() >= 600){
      Console.WriteLine("Parabens, Você foi Aprovado ");
    }
    else{
      Console.WriteLine("Você vai para prova final, digite a sua nota abaixo...");
      t.Setpf(int.Parse(Console.ReadLine()));
      if(t.MediaF() >= 60) Console.WriteLine("Parabens, Você foi Aprovado");
      else Console.WriteLine("Não foi dessa vez ");
    }
  }
}
class Notas{
  
  private int n1,n2,n3,n4;
  
    public void Setn1(int v){ if(v >= 0 && v <= 100) n1 = v; }
    public void Setn2(int v){ if(v >= 0 && v <= 100) n2 = v; }
    public void Setn3(int v){ if(v >= 0 && v <= 100) n3 = v; }
    public void Setn4(int v){ if(v >= 0 && v <= 100) n4 = v; }
  
    public int Getn1(){ return n1; }
    public int Getn2(){ return n2; }
    public int Getn3(){ return n3; }    
    public int Getn4(){ return n4; }

  private int pf;

    public void Setpf(int v){ if(v >= 0 && v <= 100) pf = v; }

    public int Getpf(){ return pf; }

  public int MediaP(){
    int Media = n1 * 2 + n2 * 2 + n3 * 3 + n4 * 3;
    return Media;
  }

  public int MediaF(){
    int Media = (n1 + n2 + n3 + n4 + pf) / 5;
    return Media;
  }
  
//  private string Nome;

//  public void SetNome(string v){ if(v != "1" || v != "2" || v != "3" || v != "4" || v != "5" || v != "6" || v != "7" || v != "8" || v != "9" || v != "0") Nome = v;}

//  public string GetNome() { return Nome; }

//  public string MostrarNome(){
//    return Nome;
//  }
}

