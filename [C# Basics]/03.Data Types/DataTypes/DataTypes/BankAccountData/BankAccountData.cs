using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Johnnie";
            string middleName = "Black";
            string lastName = "Walker";
            decimal balance = 8845258m;
            string bankName = "DSK";
            string iban = "AB 888 888 888 888";
            string card1 = "84848-595959-5996";
            string card2 = "23434-35534-553534";
            string card3 = "76886-756756-88888";
            Console.WriteLine("First name:" + firstName);
            Console.WriteLine("Middle name:" + middleName);
            Console.WriteLine("Last name:" + lastName);
            Console.WriteLine("Balance:" + balance);
            Console.WriteLine("Bank name:" + bankName);
            Console.WriteLine("IBAN:" + iban);
            Console.WriteLine("Credit card (1):" + card1);
            Console.WriteLine("Credit card (2):" + card2);
            Console.WriteLine("Credit card (3):" + card3);
        }
    }
}
