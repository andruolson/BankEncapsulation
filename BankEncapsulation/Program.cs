using System.Data;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var interaction = new UserInteraction();
            var andrewsAccount = new BankAccount();
            interaction.ATM(andrewsAccount);
        }
    }
}
