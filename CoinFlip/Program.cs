using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Random coinFlip = new Random();
            int flip = coinFlip.Next(0, 2);
            if (flip == 1){
                Console.WriteLine("Tails");
            }
            else {
                Console.WriteLine("Heads");
                }
        }
    }
}

//OR

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");

//OR

// Random coin = new Random();
// Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");