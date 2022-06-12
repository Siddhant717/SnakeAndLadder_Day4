using System;

namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startposition = 0;

            Console.WriteLine("Please enter your name :");
            string name = Console.ReadLine();

            Console.WriteLine( name+ " your current position is :" + startposition);

            Random random = new Random();
            int number = random.Next(1, 7);


            Console.WriteLine(" Now the number appeared is:" + number);
        }
    }
}
