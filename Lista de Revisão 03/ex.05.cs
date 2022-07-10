using System;

class Program {
    static void Main() {
        Console.Write("Resultado: ");
        int x = 1; 
        for (int i = 0; i < 10; i++) {
            Console.Write($"{x+i} ");
            x += i;
        }
    }
}
