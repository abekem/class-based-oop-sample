namespace ClassBasedOopSample;

public class ClassBased
{
    public void Run()
    {
        Money money = new Money
        {
            Amount = 100,
            TaxRate = 1.08
        };
        int amountIncludingTax = money.GetAmountIncludingTax();
    }

    private class Money
    {
        public int Amount { get; set; }
        public double TaxRate { get; set; }

        public int GetAmountIncludingTax()
        {
            return (int)(Amount * TaxRate);
        }
    }
}