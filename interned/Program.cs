using System;

namespace unsafe_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = "Hello";
            var world = "World!!";

            var helloWorld = $"{hello} {world}";

            Console.WriteLine(String.IsInterned(hello) ?? $"'{hello}' not interned");
            Console.WriteLine(String.IsInterned(world) ?? $"'{world}' not interned");
            Console.WriteLine(String.IsInterned(helloWorld) ?? $"'{helloWorld}' not interned");
        }
    }
}
