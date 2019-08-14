using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV1
{
    class Currentacc
    {
        public double money;
        public double newbalance;
        public string accname;
        public double overdraft;
        public double interest = 0.02;

        public void choose()  //main menu
        {
            Console.WriteLine("Enter d to deposit. Enter w to withdraw. Enter i to check interest rate. Enter o to adjust overdraft");
            string dw = Console.ReadLine();
            if (dw == "d")
            {
                deposit();
            }
            else if (dw == "w")
            {
                withdrawc();
            }
            else if (dw == "i")
            {
                interesting();
            }
            else if (dw == "o")
            {
                adjustoverdraft();
            }
        }
        public void deposit()
        {
            Console.WriteLine("Enter the amount you wish to deposit");
            double amount = Double.Parse(Console.ReadLine());
            newbalance = amount + newbalance;
            Console.WriteLine("Your new balance is :" + newbalance);
            choose();
        }
        public void withdrawc()
        {
            Console.WriteLine("Enter the amount you wish to withdraw");
            money = Double.Parse(Console.ReadLine());
            if (money + overdraft <= newbalance)
            {
                newbalance = newbalance - money;
                Console.WriteLine("Current balance: " + newbalance);
                choose();
            }
            else if (money > newbalance)
            {
                Console.WriteLine("Overdraft limit reached!");
                withdrawc();
            }
        }
        public void interesting()
        {
            Console.WriteLine("Your interest rate is 2%.After a month your balance will be: ");
            Console.WriteLine(newbalance * interest + newbalance);
            Console.WriteLine("Do you wish to add your interest now? y / n");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                newbalance = newbalance * interest + newbalance;
                Console.WriteLine("Your balance is now " + newbalance);
                choose();
            }
            else if (ans == "n")
            {
                choose();
            }
        }
        public void adjustoverdraft()
        {
            Console.WriteLine("Set overdraft, maximum overdraft limit - £200");
            overdraft = Double.Parse(Console.ReadLine());
            if (overdraft > 200)
            {
                Console.WriteLine("Overdraft limit exceeded, please select a lower amount");
                adjustoverdraft();
            }
            else if (overdraft <= 200)
            {
                overdraft = -overdraft;
                Console.WriteLine("Overdraft limit set to - " + overdraft);
                choose();
            }                
        }
    }
}
