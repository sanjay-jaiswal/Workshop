using System;

namespace Workshop
{
    class Program
    {
        const int START_POISTION = 0;
        public static int currentPosition = 0;

        public static int rollTheDie()
        {
            Random random = new Random();
            int num = random.Next(1, 7);
            return num;
        }

        static void Main(string[] args)
        {
            currentPosition += rollTheDie();
            Console.WriteLine("=====Welcome to Snake And Ladder=====");
            Console.WriteLine("The start postion of game is : " + START_POISTION);
           // Console.WriteLine("The end postion of game is : " + END_POSTION);

            Console.ReadLine();
        }
    }
}
