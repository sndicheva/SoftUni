using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // deposit - double
            // srok deposit - int
            // yearLihva - double
            double depositSum = double.Parse(Console.ReadLine());
            int depositPeriod = int.Parse(Console.ReadLine());
            double annualInterest = double.Parse(Console.ReadLine());

            // izchisljavame natrupana lihva =>  depositSum*annualInterest/100
            // izch lihvata za 1 mesec  =>  ((depositSum * annualInterest/100) / 12)
            // suma v kraja - double = deposit + srok * ((deposit * annualInterest/100) / 12)
            double sum = depositSum + depositPeriod * ((depositSum * annualInterest / 100) / 12);
            // otpechatvane rezultata na konzolata
            Console.WriteLine(sum);
        }
    }
}
