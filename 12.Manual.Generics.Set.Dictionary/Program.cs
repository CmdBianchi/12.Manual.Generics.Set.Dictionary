using System;
namespace _12.Manual.Generics.Set.Dictionary {
    class Program {
        static void Main(string[] args) {
            PrintService<int> printService = new PrintService<int>(); // ---- > Chamada do PREINTSERVICE

            Console.WriteLine("How many values? ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i =0; i<n; i++) {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());

        }
    }
}
