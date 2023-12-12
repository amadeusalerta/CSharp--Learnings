using Internal;
using System;

namespace My_Program
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        void MeetAlien()
        {
            Random numberGen=new Random();

            string name_01="X-"+numberGen.Next(10,9999);
            int age=numberGen.Next(10,500);

            Console.WriteLine("")
        }
    }
}