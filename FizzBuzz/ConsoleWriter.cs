using System;

namespace FizzBuzz
{
    class ConsoleWriter : IConsoleWriter
    {
        public void Write(string output)
        {
            Console.WriteLine(output);
        }
    }
}
