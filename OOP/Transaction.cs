namespace OOP;

public class Transaction
{
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }

    public Transaction()
    {
    }

    public Transaction(decimal amount, DateTime date)
    {
        Amount = amount;
        Date = date;
    }


    private List<Transaction> GetTransactions()
    {
        List<Transaction> transactions =
        [
            new(100, new DateTime(2020, 01, 01)),
            new(200, new DateTime(2022, 2, 1)),
            new(150, new DateTime(2023, 1, 1)),
            new(300, new DateTime(2023, 2, 1))
        ];
        return transactions;
    }


    public void Print()
    {
        var count = GetTransactions().Max();
        Console.WriteLine(count);
        // var groupBy = GetTransactions().OrderBy(t => t.Date)
        //     .GroupBy(transaction => transaction.Date.Year);

        // foreach (var t in groupBy)
        // {
        //     var sum = t.Sum(transaction => transaction.Amount);
        //     Console.WriteLine($"Year: {t.Key},Total Amount: {sum}");
        // }
    }
}