using System;

class Program {
  public static void Main() {
    velocidademedia vm = new velocidademedia();
    Console.WriteLine("Qual é a distancia em km:");
    vm.dis = int.Parse(Console.ReadLine());
    Console.WriteLine("Você gastou quanto tempo nessa viagem:");
    vm.tempo = Console.ReadLine();
    Console.WriteLine($"Você esta a {vm.Velo()} Km/hr");
  }
}
class velocidademedia{
  public int dis;
  public string tempo;
  public double Velo(){
    string [] xs = tempo.Split(":");
    int hh = int.Parse(xs[0]);
    double mm = double.Parse(xs[1]);
    double velomedia = dis  / (hh + mm / 60);
    return velomedia;    
  }
}
