using System;
using EXERCISE_02___EXCEPTION.Entities;
using EXERCISE_02___EXCEPTION.Entities.Exceptions;
namespace EXERCISE_02___EXCEPTION {
    //-----> START
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Holder: ");
            String holder = Console.ReadLine();
            Console.WriteLine("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.WriteLine("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account acc = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.WriteLine("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            try {
                acc.Withdraw(amount);
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2"));
            }
            catch (DomainException e) {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
