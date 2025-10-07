namespace BankEncapsulation;

public class UserInteraction
{
    public void ATM(BankAccount account)
    {
                    Console.WriteLine("Welcome to the Bank!");
            Console.WriteLine("_+_+_+_+_+_+_+_+_+_+_+_");

            while (true)
            {
                Console.WriteLine("Please enter pick an option:");
                Console.WriteLine("Type 1 - Make a deposit");
                Console.WriteLine("Type 2 - Check balance");
                Console.WriteLine("Type 3 - Exit");

                var parsedSuccess = int.TryParse(Console.ReadLine(), out var option);

                if (!parsedSuccess)
                {
                    Console.WriteLine("Invalid option, please try again.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Console.Write("Please enter the amount of deposit: ");
                        var depositAmountSuccess = double.TryParse(Console.ReadLine(), out var amount);
                        if (!depositAmountSuccess)
                        {
                            Console.WriteLine("Invalid amount, please try again.");
                            Thread.Sleep(3000);
                            Console.Clear();
                            continue;
                        }
                        
                        account.Deposit(amount);
                        Console.WriteLine("Your deposit is successfully deposited!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    
                    case 2:
                        Console.WriteLine($"Current balance: ${account.GetBalance()}");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Thank you for using the Bank Encapsulation!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        return; 
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                }

            }
    }
}