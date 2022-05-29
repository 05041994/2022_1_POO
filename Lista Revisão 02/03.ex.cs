using System;

class Program {
  public static void Main() {
    int n1,n2,n3,n4;
    int p1,p2,p3,p4;
    int sp,si;
    n1 = n2 = n3 = n4 = 0;
    sp = si = 0;
    

    Console.WriteLine("Digite quatro valores inteiros");
    n1 = int.Parse(Console.ReadLine());
    n2 = int.Parse(Console.ReadLine());
    n3 = int.Parse(Console.ReadLine());
    n4 = int.Parse(Console.ReadLine());

    p1 = n1 % 2;
    p2 = n2 % 2;
    p3 = n3 % 2;
    p4 = n4 % 2;

    if(p1 == 0 || p1 == 1){
      if (p1 == 0){
        sp = n1;
      }if (p1 == 1){
        si = n1;
      }
      if(p2 == 0){
        sp = sp + n2;
      }if(p2 == 1){
        si = si + n2;
      }    
      if(p3 == 0){ 
        sp = sp + n3;
      }if(p3 == 1){
        si = si + n3;        
      }if (p4 == 0){
        sp = sp + n4;
      }else if (p4 == 1){
        si = si + n4;
      }
    }
          
    Console.WriteLine("Soma dos pares = " + sp);
    Console.WriteLine("Soma dos impares = " + si);
      
  }
}
