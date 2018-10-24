using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 3 :\n");
            int num = 1;
            while (num<=20)
            {
                Console.Write(num + " ");
                num++;
                if(num==6 || num == 11 || num == 16)
                {
                    Console.WriteLine("\n");
                }
            }
            Console.ReadLine();
        }
    }
}
