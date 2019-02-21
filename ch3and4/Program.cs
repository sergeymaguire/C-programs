using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3and4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int aLotofMoney = 23548797;
            //int aLotofMoneys = 24_4578_45;
            //int annualSalary = -70000;
            //Console.WriteLine("test");
            //Console.WriteLine(aLotofMoney);
            //Console.WriteLine(aLotofMoneys);
            //  Console.WriteLine(annualSalary);
            int anInt = 45555557;
            uint aUnsnInt = 257;
            double myMoney = 14.00;
            Console.WriteLine(myMoney);
            double someMoney = 123;
            string moneyString;
            moneyString = someMoney.ToString("F4");
            Console.WriteLine(moneyString);
            Console.WriteLine("Here is an int {0} here is the unassinged int {1}.", anInt, aUnsnInt);
            double mohhhMoney = 478952;
            string currencyMoney;
            currencyMoney = mohhhMoney.ToString("C");
            Console.WriteLine(currencyMoney);
            Console.ReadLine();
        }
    }
}
