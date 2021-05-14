using System;

namespace equals
{
    class Person
    {
        public string FirstName;
        public string LastName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var personOne = new Person { FirstName = "Jane", LastName = "Doe" };
            var personTwo = new Person { FirstName = "Jane", LastName = "Doe" };

            Console.WriteLine($"Compare persons: {personOne == personTwo}");

            Console.ReadLine();

            var stringOne = "Hello World";
            var stringTwo = "Hello" + " " + "World";

            var hello = "Hello";
            var world = "World";
            var stringThree = $"{hello} {world}";

            Console.WriteLine($"String == comparison: {stringOne == stringTwo}");
            Console.WriteLine($"String == comparison, runtime strings: {(stringOne) == (stringThree)}");

            Console.ReadLine();

            Console.WriteLine($"Object == comparison, compiled strings: {(Object)stringOne == (Object)stringTwo}");
            Console.WriteLine($"Object == comparison, runtime strings: {((Object)stringOne) == ((Object)stringThree)}");

            Console.ReadLine();
            Console.WriteLine($"String Three isInterned: {String.IsInterned(stringThree)}");


            Console.ReadLine();
            var internedStringThree = String.Intern(stringThree);
            Console.WriteLine($"Object == comparison, runtime strings: {((Object)stringOne) == ((Object)stringThree)}");
            Console.WriteLine($"Object == comparison, runtime string, interned: {((Object)stringOne) == ((Object)internedStringThree)}");

        }

    }
}

