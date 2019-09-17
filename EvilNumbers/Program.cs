using System;

namespace EvilNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (short index = 0; index <= 50; index++) {
                Console.WriteLine($"{index}:    {EvilThings.IsEvilNumberStatic(index)}");
            }
        }
    }
}
