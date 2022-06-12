using System;

namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
             const int NoPlay = 0, Ladder = 1, Snake = 2;
            int startposition = 0;

          

            Console.WriteLine("Player position is "+ startposition);
            Random random = new Random();
            int number = random.Next(1, 7);
            Console.WriteLine("After rolling the die,the number is" + number);
            startposition = startposition + number;
            Console.WriteLine("Position of Player is " + startposition);

            while (startposition < 100)
            {
                int option = random.Next(0, 3);

                switch (option)
                {
                    case NoPlay:
                        startposition += 0;
                        Console.WriteLine("Player stays in the same position");
                        break;
                    case Ladder:
                        startposition += number;
                        Console.WriteLine("Yeah!Ladder {0} ", startposition);
                        break;
                    case Snake:
                        startposition -= number;
                        Console.WriteLine("Oops!Snake {0} ", startposition);
                        if (startposition < 0)
                        {
                            startposition = 0;
                        }
                        break;


                }
            }

        }

    }   
}
