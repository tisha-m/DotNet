using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}
class BankAccount
{
    double balance = 50000;
    public void Withdraw(double amount)
    { 
        if (amount > balance)
        {
            throw new InsufficientBalanceException("Error" + "Insufficient balance");
        }
        balance = balance - amount;
        Console.WriteLine("Remaining balance: " + balance);
        Console.WriteLine("Withdrawal Successful");
    }
}
class T6_08
{
    public static void T6_08Main()
    {
        BankAccount b = new BankAccount();
        try
        {
            Console.Write("Enter amount to withdraw:");
            double amount = Convert.ToDouble(Console.ReadLine());
            b.Withdraw(amount);
        }
        catch(InsufficientBalanceException e)
        {
            Console.WriteLine("Error" + e);
        }
        }
}