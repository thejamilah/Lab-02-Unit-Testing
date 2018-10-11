using System;

namespace Bank_ATM
{
    public class Program
    {
        public static double Balance = 10000;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bank of Jamilah");
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Please Make a Selection\n" +
                "1 Check Balance\n" +
                "2 Withdrawal\n" +
                "3 Deposit\n" +
                "4 Exit");
            int userSelection = int.Parse(Console.ReadLine());
            //Console.WriteLine(userSelection);
            switch (userSelection)
            {
                case 1:
                    CheckBalance();
                    break;

                case 2:
                    Withdrawal();
                    break;

                case 3:
                    break;

                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please Select Items 1 - 4");
                    Menu();
                    break;
            }
            //Check Balance
            //Withdrawal
            //Deposit
            //Exit
        }
        public static void CheckBalance()
        {
            Console.WriteLine($"Your Balance is:{Balance}");
            Menu();
        }

        public static void Withdrawal()
        {
            Console.WriteLine("How much would you like to withdraw?\n");
            double userSelection = double.Parse(Console.ReadLine());
            //withdrawal for more than available balance
            WithdrawalFromBalance(userSelection);
        }

        public static double WithdrawalFromBalance(double withdrawalAmount)
        {
            Balance -= withdrawalAmount;
            Console.WriteLine(Balance);
            return Balance;
        }
    }
}
