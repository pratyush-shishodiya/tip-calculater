using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{

class Program
{

    static void Main(string[] args)
    {
        string answer;
        float totalPrice;
        float tippercentage;
        int people;
        float tipperhead;
        float billperhead;
        Console.WriteLine("Would you like to calculate a tip?");
        answer = Console.ReadLine();
        if (answer == "yes")
        {
            Console.WriteLine("Please enter the total price of your meal");
            totalPrice = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter the tip percantage");
            tippercentage = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter the number of people");
            people = int.Parse(Console.ReadLine());
            
            tipperhead=totalPrice*(tippercentage/100);
            tipperhead=tipperhead/2;
        
            
            billperhead=totalPrice/2+tipperhead;
            
            Console.WriteLine($"Total amount to pay:{totalPrice:c}\nbill per person:{billperhead:c}\nTip amount per person:{tipperhead:c}");

            

        }
        else if (answer == "no")
            Console.WriteLine("Please run this again when you wish to calculate a tip.");
        else
            Console.WriteLine("Error. Please type in \"yes\" or \"no\"");

        Console.ReadLine();
    }

}
}
