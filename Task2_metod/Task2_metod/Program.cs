using System;

namespace Task2_metod
{
    class Program
    {
        static void Main(string[] args)
        {


            int num1 = Convert.ToInt32(Console.ReadLine());
            char num3 = Convert.ToChar(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(process(num1,num3,num2));

        }

        public static int process(int num1, char num3, int num2)
            {
            return num1 * num2;

             }

    }
}
