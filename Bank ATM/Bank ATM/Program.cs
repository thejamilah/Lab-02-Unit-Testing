using System;

namespace Bank_ATM
{
    public class Program
    {
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
            switch(userSelection)
            {
                case 1:
                    break;

                case 2:
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
            //Withdraw
            //Deposit
            //Exit
        }
    }
}
