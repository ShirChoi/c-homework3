using System;

namespace Problem3 {
    class Program {
        static void Main(string[] args) {
            int a = ReadInt("a");
            int b = ReadInt("b");
            int c = ReadInt("c");

            if(b > a)
                Swap(ref a, ref b);
            
            if(c > a)
                Swap(ref a, ref c);

            if(c > b)
                Swap(ref b, ref c);

            System.Console.WriteLine($"a = {a}, b = {b}, c = {c}");    
        }

        static void Swap(ref int a, ref int b) {
            int c = a;
            a = b;
            b = c;
        }

        static int ReadInt(string name) {
            System.Console.Write($"{name} = ");
            return int.Parse(Console.ReadLine());
        }
    }
}
