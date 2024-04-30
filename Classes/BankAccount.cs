namespace Classes;

public class BankAccount
{
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }

    public void MakeDeposit(decimal amount, Datetime date, string note)
    {
    }

    public void MakeWithdrawal(decimal amount, Datetime date, string note)
    {
    }
}