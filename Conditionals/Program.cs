namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 93;
            if (number < 100)
            {
                if (number > 90 && number < 95)
                {
                    Console.WriteLine("Number is between 90 - 95");
                }
                else
                {
                    Console.WriteLine("Number is not between 90 - 95");
                }
            }
            Console.ReadLine();
        }
    }
}