using System;

namespace Task3_metod
{
    class Program
    {
        static void Main(string[] args)
        {



            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Divide(number));

        }


        public static int Divide(int num)
        {
            int tempcost = 0;
            if (num < 50)
            {
                tempcost = 3;
                Search(num, tempcost);
            }
            else if (num >= 50 && num < 100)
            {
                tempcost = 5;
                Search(num, tempcost);
            }
            else if (num >= 100)
            {
                tempcost = 8;
                Search(num, tempcost);

            }
            return Search(num, tempcost);

        }

        public static int Search(int num, int cost)
        {

            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % cost == 0)
                {

                    count++;
                }
            }
            return count;
        }
    }
}
