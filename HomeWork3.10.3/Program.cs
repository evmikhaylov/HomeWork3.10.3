using System;

namespace HomeWork3._10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int i = int.Parse(Console.ReadLine());
            int n = 2;
            bool statNum = true;
            while (statNum)
                {
                if (i % n == 0 & n<=i)
                {
                    statNum = true;
                    break;
                }
                else
                {
                    statNum = false;
                } 
                    
                n++;
                }
            if(statNum == true)
            {
                Console.WriteLine($"число {i} сложное");
            }
            else
            {
                Console.WriteLine($"число {i} простое");
            }
            
            Console.ReadLine();
        }


    }
}
