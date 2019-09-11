using System;

namespace ExperienceyouHave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years experience do you have in professional programming?");
            int Exp = int.Parse(Console.ReadLine());
            for (int i = 0; i <= Exp; i++)
            {
                Console.WriteLine("You Have "  + i.ToString() +  " years of Experience");

            }
        }
    }
}
