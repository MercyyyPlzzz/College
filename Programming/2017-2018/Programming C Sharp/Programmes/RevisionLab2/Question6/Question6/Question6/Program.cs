using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            double change,TwoEuro=2,Euro=1,FiftyCent=.5,TwentyCent=.2,TenCent=.1,FiveCent=.05,TwoCent=.02,OneCent=.01;
            Console.WriteLine("Question 6 : ");
            Console.WriteLine("\nEnter an amount : ");
            change = double.Parse(Console.ReadLine());

            double aTwoEuro = (int)(change / TwoEuro);
            double aEuro = (int)((change % TwoEuro) / Euro);
            double aFiftyCent = (int)(((change % TwoEuro) % Euro) / FiftyCent);
            double aTwentyCent = (int)((((change % TwoEuro) % Euro) % FiftyCent) / TwentyCent);
            double aTenCent = (int)(((((change % TwoEuro) % Euro) % FiftyCent) % TwentyCent) / TenCent);
            double aFiveCent = (int)((((((change % TwoEuro) % Euro) % FiftyCent) % TwentyCent) % TenCent) / FiveCent);
            double aTwoCent = (int)(((((((change % TwoEuro) % Euro) % FiftyCent) % TwentyCent) % TenCent) % FiveCent)/TwoCent);
            double aOneCent = (int)((((((((change % TwoEuro) % Euro) % FiftyCent) % TwentyCent) % TenCent) % FiveCent) % TwoCent)/OneCent);

            Console.WriteLine("The amount of TwoEuros are....{0}", aTwoEuro);
            Console.WriteLine("The amount of Euros are....{0}", aEuro);
            Console.WriteLine("The amount of FiftyCent are....{0}", aFiftyCent);
            Console.WriteLine("The amount of TwentyCent are....{0}", aTwentyCent);
            Console.WriteLine("The amount of TenCent are....{0}", aTenCent);
            Console.WriteLine("The amount of FiveCent are....{0}", aFiveCent);
            Console.WriteLine("The amount of TwoCent are....{0}", aTwoCent);
            Console.WriteLine("The amount of OneCent are....{0}", aOneCent);
            Console.ReadLine();
        }
    }
}
