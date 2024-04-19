namespace SplittheBill;

public class TipPerPersonCalc
{
    public decimal CalcTipPerPerson(decimal price, int numPatrons, float tipPercent)
    {
        if (numPatrons <= 0)
            throw new ArgumentException("Number of patrons must be greater than zero.");

        decimal totalAmount = price * (decimal)(tipPercent / 100);
        return totalAmount / numPatrons;
    }
}