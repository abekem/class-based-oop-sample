namespace ClassBasedOopSample;

public class Money
{
    private int Amount { get; set; } // 金額
    private string Currency { get; set; } = "USD"; // 通貨

    // 金額を加算する
    public Money Add(Money money)
    {
        if (money.Currency != Currency)
        {
            // 通貨が異なる場合はエラー
            throw new InvalidOperationException("Currency mismatch");
        }
        return new Money { Amount = Amount + money.Amount, Currency = Currency };
    }
}