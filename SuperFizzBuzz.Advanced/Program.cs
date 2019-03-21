using System;
using System.Collections.Generic;

namespace SuperFizzBuzz.Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = new Range(-12, 145);
            var replacements = new Dictionary<int, string>() {
                { 3, "Fizz"},
                { 7, "Buzz"},
                { 38, "Bazz"}
            };

            var sfb = new SuperFizzBuzz(range, replacements);

            foreach(var fb in sfb.Get()) {
                Console.WriteLine($"{fb}");
            }
        }
    }
}
