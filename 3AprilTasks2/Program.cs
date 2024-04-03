internal class Program
{
    public static void Main(string[] args)
    {
        // Design a banking system where you have different types of accounts such as SavingsAccount and CurrentAccount.
        //  Create an interface called IAccount with methods like Deposit(), Withdraw(), and CalculateInterest().
        //   Implement this interface in both SavingsAccount and CurrentAccount classes.
        //    Use abstraction to define a base class Account with common properties 
        //   like AccountNumber, Balance, and abstract methods like ShowAccountDetails(). Implement ShowAccountDetails()
        //    differently in each derived class.

SavingsAccount savingsAccount=new SavingsAccount();
savingsAccount.AccountNumber="123456789";
savingsAccount.Deposit(100);
savingsAccount.CalculateInterest();
savingsAccount.ShowAccountDetails();

System.Console.WriteLine("****************");

CurrenAccount currenAccount=new CurrenAccount();

currenAccount.AccountNumber="987654321";
currenAccount.Deposit(200);
currenAccount.CalculateInterest();
currenAccount.ShowAccountDetails();

    }
}