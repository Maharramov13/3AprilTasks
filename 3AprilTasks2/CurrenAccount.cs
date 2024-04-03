class CurrenAccount:Account,IAcoount
{
    public void Deposit(double amount){
        Balance+=amount;
        System.Console.WriteLine($"{amount}manat cari hesaba yatirildi");
    }
public void Withdraw(double amount){
    if(Balance>=amount){
        Balance-=amount;
        System.Console.WriteLine($"{amount} manat cari hesabdan cixildi.");
    }
    else{
        System.Console.WriteLine("Balansda kifayet qeder mebleg yoxdu.");
    }
}

public void CalculateInterest(){
    System.Console.WriteLine("Cari hesablar ucun faiz hesablanmir.");
}

    public override void ShowAccountDetails()
    {
        System.Console.WriteLine($"Cari hesab nomresi {AccountNumber}");
        System.Console.WriteLine($"Cari hesab balansi {Balance} manat ");
    }

}