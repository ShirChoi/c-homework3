using System;

namespace Problem1 {
    class Program {
        static void Main(string[] args) {
            
            double price = Read("price");

            if(price > 1000) 
                price *= 0.95;
            else if (price > 500) 
                price *= 0.97;

            System.Console.WriteLine($"Price with discount = {price}");
        }

        static double Read(string name) {
            System.Console.Write($"{name} = ");
            return double.Parse(Console.ReadLine());
        }
    }
}
