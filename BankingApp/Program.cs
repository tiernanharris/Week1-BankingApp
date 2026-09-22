
using System.Xml.Serialization;

void BankingApp()
{
    int choice = 0;
    double depositAmount;
    double accountBalance = 1000.00;

    while (choice != 0)
    {
        Console.WriteLine("Please choose an option from below.");
        Console.WriteLine("===================================");
        Console.WriteLine("1 - Deposit or withdraw funds.");
        Console.WriteLine("2 - View current account information.");
        Console.WriteLine("0 - Exit");
        Console.WriteLine("Please choose an option.");


        choice = Convert.ToInt32(Console.ReadLine());


        {
            if (choice == 1 || choice == 2)
            {
                if (choice == 1)
                {
                    Console.WriteLine("You have choosen to deposit or withdraw funds");
                    Console.WriteLine("How much do you want to deposit?");
                    Console.WriteLine("Enter the amount including pence using a decimal point");

                    depositAmount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Your orginal account balance was {accountBalance} ");

                    accountBalance += depositAmount;
                    Console.WriteLine($"Your new account balance is {accountBalance}");

                }

                if (choice == 2)
                {
                    Console.WriteLine("You have chosen to view current account information");
                    Console.WriteLine($"Your current account balance is {accountBalance}");


                }
            }
            else
            {
                Console.WriteLine("Invalid choice, please choose 1 or 2.");
            }
        }
    }
}

BankingApp();