using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int FizzCount = 0;
            int BuzzCount = 0;
            int FizzbuzzCount = 0;

            for(int i = 0; i <= 1000; i++)
            {
                if(i%3 == 0 && i%5 != 0){
                    Console.WriteLine("Fizz");
                    FizzCount++;
                }
                else if(i%5 == 0 && i%3 != 0){
                    System.Console.WriteLine("Buzz");
                    BuzzCount++;
                }
                else if(i%5 == 0 && i%3 ==0){
                    System.Console.WriteLine("Fizzbuzz");
                    FizzbuzzCount++;
                }
                else
                    System.Console.WriteLine(i);
            }
            System.Console.WriteLine("Fizz Count: " + FizzCount + " Buzz Count: " + BuzzCount + " Fizzbuzz Count: " + FizzbuzzCount);
        }
    }
}
