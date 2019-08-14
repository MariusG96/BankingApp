using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppV1
{
    class Savingacc
    {
        public double money;
        public double newbalance;
        public string accname;
        public double interest = 0.05; // 5%

        public void choose()  //main menu
        {
            Console.WriteLine("Enter d to deposit. Enter w to withdraw. Enter i to check interest rate");
            string dw = Console.ReadLine();
            if (dw == "d")
            {
                deposit();
            }
            else if (dw == "w")
            {
                withdraws();
            }
            else if (dw == "i")
            {
                interesting();
            }
        }
        public void deposit()
        {
            Console.WriteLine("Enter the amount you wish to deposit");
            money = Double.Parse(Console.ReadLine());

            newbalance = money + newbalance;

            Console.WriteLine("Your new balance is :" + newbalance);
            choose();
        }
        public void withdraws()
        {
            Console.WriteLine("Enter the amount you wish to withdraw");
            money = Double.Parse(Console.ReadLine());
            if (money < newbalance)
            {
                newbalance = newbalance - money;
                Console.WriteLine("Current balance: " + newbalance);
                choose();
            }
            else if (money > newbalance)
            {
                Console.WriteLine("Insuficcient Funds!");
                withdraws();
            }          
        }
        public void interesting()
        {
            Console.WriteLine("Your interest rate is 5 %.After a month your balance will be: ");
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
    }
}
