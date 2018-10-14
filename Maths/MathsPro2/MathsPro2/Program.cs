using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsPro2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            do
            {
                userInput = showMenu();
                switch (userInput)
                {
                    case 1:
                        Multiples3N5();
                        break;

                    case 2:
                        PosPrimeFactors();
                        break;

                    case 3:
                        EvenFib();
                        break;

                    case 4:
                        Euclidean();
                        break;

                    case 5:
                        RSAEncrypt();
                        break;

                    case 6:
                        RSADecrypt();
                        break;
                    case 7:
                        Console.WriteLine("This application will now close...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("This option is invalid");
                        break;
                }
            } while (userInput != 7);
        }
        static public int showMenu()
        {
            int userInput;
            Console.WriteLine("     Main Maths Project");
            Console.WriteLine(" ");
            Console.WriteLine(" 1. Sum of all multiples of 3 and 5 below a Specified Value");
            Console.WriteLine(" ");
            Console.WriteLine(" 2. Prime Factorization of a Positive Integer");
            Console.WriteLine(" ");
            Console.WriteLine(" 3. Sum of all even Fibonacci numbers");
            Console.WriteLine(" ");
            Console.WriteLine(" 4. Extended Euclidean Algorithm");
            Console.WriteLine(" ");
            Console.WriteLine(" 5. RSA Encryption");
            Console.WriteLine(" ");
            Console.WriteLine(" 6. RSA Decryption");
            Console.WriteLine(" ");
            Console.WriteLine(" 7. Exit");
            Console.WriteLine(" ");
            Console.WriteLine(" Enter a Number :");
            userInput = int.Parse(Console.ReadLine());
            return (userInput);
        }
        static public int Multiples3N5()
        {
            int n = 0;//sum = 0;
            Console.WriteLine("");
            Console.WriteLine("Enter a number that is less than 50000 : ");
            n = int.Parse(Console.ReadLine());
            int x3 = n / 3;
            int x5 = n / 5;
            int x15 = n / 15;
            long sum1 = 3 * x3 * (x3 + 1);
            long sum2 = 5 * x5 * (x5 + 1);
            long sum3 = 15 * x15 * (x15 + 1);
            //Based on : 1+2+...+n=n*(n+1)/2
            long sum = (sum1 + sum2 - sum3) / 2;
            Console.WriteLine(" ");
            Console.WriteLine("The sum of multiples of 3 and 5 which were less than "+n+" : {0}",sum);
            Console.WriteLine(" ");
            return (0);
        }
        static public int Euclidean()
        {
            int x = 1, y = 1,a,b;
            Console.WriteLine("Enter a number for a :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Enter a number for b :");
            b = int.Parse(Console.ReadLine());
            int d = EuclideanHelper(a, b, x, y);
            Console.WriteLine("");
            Console.WriteLine("GCD("+a+","+b+") = " + d);
            Console.WriteLine("x =" + x + "," + "y =" + y);
            return (0); 
        }
        static public int EuclideanHelper(int a, int b, int x, int y)
        {
            if(a==0)
            {
                x = 0;
                y = 1;
                return b;
            }
            int x1 = 1, y1 = 1;
            int d = EuclideanHelper(b % a, a, x1, y1);
            //Update x & y
            x = y1 - (b / a) * x1;
            y = x1;
            return (d);
        }
        static public int PosPrimeFactors()
        {
            long n;
            int i, j = 0;
            Console.WriteLine("Enter an Integer to be factorised : ");
            n = long.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("All Prime Factors : ");
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }
            for(i=3;i<=Math.Sqrt(n);i+=2)
            {
                while(n%i==0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }
            if(n>2)
            {
                Console.Write(n);
            }
            
            Console.WriteLine(" ");
            
            for (i = 2; n > 1; i++)
            {
                if (n % i == 0)
                {
                    while (n % i == 0)
                    {
                        n /= i;
                        j++;
                    }
                }      
            }
            Console.WriteLine(" ");
            Console.WriteLine("{0} is a prime factor {1} times", i, j);
            return (0);
        }
        static public int EvenFib()
        {
            long fib3 = 2;//Fn-3=F3=2
            long fib6 = 0;//Fn-6=F0=0
            long result = 2;
            long adder = 0;
            long n = 0;
            Console.WriteLine("Enter a natural number less than 5000000 : ");
            n = long.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            while (result < n)
            {
                adder += result;
                result = 4 * fib3 + fib6;
                fib6 = fib3;
                fib3 = result;
            }
            Console.WriteLine("Sum of all Even Fibonacci Numbers : {0}",fib3);
            Console.WriteLine("");
            return (0); 
        }
        static public int RSAEncrypt()
        {
            return (0);
        }
        static public int RSADecrypt()
        {
            return (0);
        }
    }
}
