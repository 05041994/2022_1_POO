using System;

class Program {
  public static void Main() {
    Viagem t = new Viagem();
    Console.WriteLine("Qual a distancia em km percorrida na sua viagem:");
    double dist = double.Parse(Console.ReadLine());
    Console.WriteLine("Qanto tempo você gastou (hh:mm:ss)");
    string tempo = Console.ReadLine();
    string[] v = tempo.Split(':');
    int h = int.Parse(v[0]);
    int m = int.Parse(v[1]);
    int s = int.Parse(v[2]);
    double horas = h + m/60.0 + s/3600.0;

    Viagem minhaViagem = new Viagem();
      minhaViagem.SetDistancia(dist);
      minhaViagem.SetTempo(horas);
    Console.WriteLine($"A sua velocidade media é de {minhaViagem.VelocidadeMedia()} Km/h");
    
  }
}
class Viagem{
  private double distancia;
  private double Tempo = 1;
   public void SetDistancia(double v){
      if(v > 0) distancia = v;
    }
    public void SetTempo(double v){
      if(v > 0) Tempo = v;
    }
    public double GetDistancia(){
      return distancia;
    }
    public double GetTempo(){
      return Tempo;
    }
  public double VelocidadeMedia(){
    double vm = distancia / Tempo;
    return vm;
  }
}
