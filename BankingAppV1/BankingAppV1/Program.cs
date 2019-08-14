using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace BankingAppV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 's' if you want a savings account. Enter 'c' if you want current account.");
            string which = Console.ReadLine();
            if (which == "s")
            {
                Savingacc savebank;
                savebank = new Savingacc();
                Console.WriteLine("Please enter the name of your account");
                savebank.accname = Console.ReadLine();
                Console.WriteLine($"Welcome, {savebank.accname}, please select one of the options below");
                savebank.choose();
            }
            else if (which == "c")
            {
                Currentacc curbank;
                curbank = new Currentacc();
                Console.WriteLine("Please enter the name of your account");
                curbank.accname = Console.ReadLine();
                Console.WriteLine($"Welcome, {curbank.accname}, please select one of the options below");
                curbank.choose();
            }
        }
    }
}
