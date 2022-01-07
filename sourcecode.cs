using System;

namespace tipcalculater
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tip calculater.\nPlease enter the amount");
            double amount=double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the tip percentage you want to give.");
            double tippercentage=double.Parse(Console.ReadLine());
            double tipamount=0,totalpayble=0;
            if(tippercentage>20.0)
            {
                Console.WriteLine("Tip is above limit.");

            }
            if(tippercentage<0.0){
                tipamount=0;
            }
            tipamount=tippercentage/100*amount;
            totalpayble=amount+tipamount;
            Console.WriteLine($"Total amount to pay:{totalpayble:c}\nTotal Purachse:{amount:c}\nTip amount:{tipamount:c}");
        }
    }
}
