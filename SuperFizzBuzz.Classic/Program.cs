using System;
using System.Collections.Generic;

namespace SuperFizzBuzz.Classic
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = new Range(1, 20);
            var replacements = new Dictionary<int, string>() {
                { 3, "Fizz"},
                { 5, "Buzz"}
            };

            var sfb = new SuperFizzBuzz(range, replacements);

            foreach(var fb in sfb.Get()) {
                Console.WriteLine($"{fb}");
            }
        }
    }
}
