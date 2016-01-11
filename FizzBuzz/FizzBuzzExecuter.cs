using System;

namespace FizzBuzz
{
    public class FizzBuzzExecuter
    {
        private IConsoleWriter consoleWriter;

        public FizzBuzzExecuter(IConsoleWriter consoleWriter)
        {
            if (consoleWriter == null) throw new ArgumentNullException("consoleWriter");
            this.consoleWriter = consoleWriter;
        }

        public void Execute()
        {
            for (int i = 1; i <= 100; i++)
            {
                //if ((i % 3 == 0) && (i % 5 == 0))
                //{
                //    this.consoleWriter.Write("FizzBuzz");
                //    continue;
                //}

                if (i % 3 == 0)
                {
                    this.consoleWriter.Write("Fizz");
                    continue;
                }

                //if (i% 5 == 0)
                //{
                //    this.consoleWriter.Write("Buzz");
                //    continue;
                //}

                this.consoleWriter.Write(i.ToString());
            }
       }
    }
}
