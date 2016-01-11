namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzExecuter =
                new FizzBuzzExecuter(
                     new ConsoleWriter());

            fizzBuzzExecuter.Execute();
        }
    }
}
