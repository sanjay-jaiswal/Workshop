using System;

namespace Workshop
{

    public class Program
    {
        int START_POISTION = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("=====Welcome to Snake And Ladder=====");

            Program pg = new Program();
            Console.WriteLine("The start postion of game is : " + pg.START_POISTION);
        }
    }
}
