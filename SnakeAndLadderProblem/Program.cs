using System;

namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            int startposition = 0;
            Console.WriteLine("Current Position is " + startposition);

            Random random = new Random();
            int number = random.Next(1, 7);
            Console.WriteLine("The number appeared on dice is " + number);

            int option = random.Next(0, 3);

            switch (option)
            {
                case 0:
                    Console.WriteLine("No play");
                    
                    break;
                case 1:
                    Console.WriteLine("Yeah!Ladder");
                    startposition = startposition + number;
                    Console.WriteLine("Now your position is " + startposition);
                    break;
                case 2:
                    Console.WriteLine("Oops!Snake");
                   
                    startposition = startposition - number;

                    Console.WriteLine("Again come back to " + startposition);
                    break;

            }   }   
    }
}
