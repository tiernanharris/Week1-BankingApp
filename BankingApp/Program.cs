
using System.Xml.Serialization;

void BankingApp()
{
    int choice = 0;
    double depositAmount;
    double accountBalance = 1000.00;
    double withdrawAmount;

    while (choice != 4)
    {
        Console.WriteLine("Please choose an option from below.");
        Console.WriteLine("===================================");
        Console.WriteLine("1 - Deposit funds.");
        Console.WriteLine("2 - Withdraw funds.");
        Console.WriteLine("3 - View current account information.");
        Console.WriteLine("4 - Exit");
        Console.WriteLine("Please choose an option.\n");


        choice = Convert.ToInt32(Console.ReadLine());


        {
            if (choice == 1)
            {
                Console.WriteLine("\nYou have choosen to deposit funds. \nHow much do you want to deposit?");
                Console.WriteLine("\nEnter the amount including pence using a decimal point.");

                depositAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nYour orginal account balance was {accountBalance}. ");

                accountBalance += depositAmount;
                Console.WriteLine($"\nYour new account balance is {accountBalance}.");
                Console.WriteLine();

            }
            else if (choice == 2)
            {
                Console.WriteLine("\nYou have choosen to withdraw funds. \nHow much do you want to withdraw?");
                Console.WriteLine("\nEnter the amount including pence using a decimal point.");

                withdrawAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nYour orginal account balance was {accountBalance}. ");

                accountBalance -= withdrawAmount;
                Console.WriteLine($"Your new account balance is {accountBalance}.");
                Console.WriteLine();

            }

            else if (choice == 3)
            {
                Console.WriteLine("\nYou have chosen to view current account information.");
                Console.WriteLine($"\nYour current account balance is {accountBalance}.");
                Console.WriteLine();



            }

            else if (choice == 4)
            {
                Console.WriteLine("\nThankyou, goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice, please choose 1, 2, 3 or 4.");
            }
        }
    }
}

    BankingApp();
