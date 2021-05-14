using System;

namespace unsafe_example
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                var example = "Hello World!!";

                example[0] = 'G';
                example[1] = 'o';
                example[2] = 'o';
                example[3] = 'd';
                example[4] = 'b';
                example[5] = 'y';
                example[6] = 'e';
                example[7] = ' ';
                example[8] = 'W';
                example[9] = 'o';
                example[10] = 'r';
                example[11] = 'l';
                example[12] = 'd';

                Console.WriteLine(example);

            }

        }
    }
}
