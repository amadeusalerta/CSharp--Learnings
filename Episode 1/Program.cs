using System;

namespace MyProgram
{


    class AgeCalculator
    {
        static void Main(string[] args)
        {

            int age = 18;
            double height = 172;
            bool alive = true;
            char symbol = '@';
            String name = "Amadeus";
            const int passwd = 1928374650;

            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height);
            Console.WriteLine("Are you alive " + alive);
            Console.WriteLine("Your symbol is " + symbol);
            Console.WriteLine("Your Password is " + passwd);
;
            Console.ReadKey();
        }

    }



}