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
                    Deposit();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please Select Items 1 - 4");
                    Menu();
                    break;
            }

        }
        public static void CheckBalance()
        {
            Console.WriteLine($"Your Balance is:{Balance}");
            Menu();
        }

        public static void Withdrawal()
        {
            Console.WriteLine("How much would you like to withdraw?\n");

            try
            {
                double userSelection = double.Parse(Console.ReadLine());
                if(userSelection > Balance)
                {
                    Console.WriteLine("You can not take more than you give!");
                    Withdrawal();
                }
                WithdrawalFromBalance(userSelection);

            }

            catch(Exception)

            {
                Withdrawal();
            }
            
            
        }

        public static double WithdrawalFromBalance(double withdrawalAmount)
        {
            Balance -= withdrawalAmount;
            Console.WriteLine(Balance);
            return Balance;
        }

        public static void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?\n");
            
            try
            {
                double userSelection = double.Parse(Console.ReadLine());
                if(userSelection < 0 )
                {
                    Console.WriteLine("You can not deposit a negative amount!");
                    Deposit();
                }
                DepositIntoBalance(userSelection);
            }
            catch (Exception)
            {

                Deposit();
            }

            
        }

        public static double DepositIntoBalance(double depositAmount)
        {
            Balance += depositAmount;
            Console.WriteLine(Balance);
            return Balance;
        }
    }
}
