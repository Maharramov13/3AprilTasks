class SavingsAccount:Account,IAcoount
{
    public void Deposit(double amount){
        Balance+=amount;

        System.Console.WriteLine($"{amount} manat hesaba yatirildi");
    }

    public void Withdraw(double amount){
        if (Balance>=amount)
        {
            Balance-=amount;
            System.Console.WriteLine($"{amount}  manat hesabdan cixdi: ");
        }
        else{
            System.Console.WriteLine("Balansda kifayet qeder mebleg yoxdu");
        }
    }

    public void CalculateInterest()
    {
        double interestRate=0.05;
        double interest=Balance*interestRate;
        Balance+=interest;
        System.Console.WriteLine($"Faiz hesablandi ve birinci hesaba elave olundu: {interest}");
    }

    public override void ShowAccountDetails()
    {
        System.Console.WriteLine("Birinci hesab nomresi: "+AccountNumber);
        System.Console.WriteLine("Balansda olan miqdar: "+Balance);
    }

}
