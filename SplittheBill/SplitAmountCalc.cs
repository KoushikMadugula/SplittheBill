namespace SplittheBill;

public class SplitAmountCalc
{
    public decimal CalcTotalSplitAmount(decimal amount, int numPeople)
    {
        if (numPeople <= 0)
            throw new ArgumentException("Number of people must be always greater than zero.");

        return amount / numPeople;
    }
}