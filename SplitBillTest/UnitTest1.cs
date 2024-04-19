namespace SplitBillTest;
using SplittheBill;
using System;

[TestClass]
public class SplitAmountCalcTests
{
    [TestMethod]
    public void CalculateTotalSplitAmount_InputGivenValid_ReturnsCorrectAmount()
    {
        decimal amount = 250.0m;
        int numPeople = 10;
        decimal expectedSplitAmount = 25.0m;
        SplitAmountCalc splitCalc = new SplitAmountCalc();
        decimal actualSplitAmount = splitCalc.CalcTotalSplitAmount(amount, numPeople);
        Assert.AreEqual(expectedSplitAmount, actualSplitAmount);
    }

    [TestMethod]
    public void CalculateTotalSplitAmount_ZeroPeople_ThrowsException()
    {
        decimal amount = 250.0m;
        int numPeople = 0;
        SplitAmountCalc splitCalc = new SplitAmountCalc();
        Assert.ThrowsException<ArgumentException>(() => splitCalc.CalcTotalSplitAmount(amount, numPeople));
    }

    [TestMethod]
    public void CalculateTotalSplitAmount_NegativeValueForPeople_ThrowsException()
    {
        decimal amount = 250.0m;
        int numPeople = -10;
        SplitAmountCalc splitCalc = new SplitAmountCalc();
        Assert.ThrowsException<ArgumentException>(() => splitCalc.CalcTotalSplitAmount(amount, numPeople));
    }

    [TestClass]
    public class TipCalcTests
    {
    [TestMethod]
    public void CalcTip_InputGivenValid_ReturnsCorrectTipAmounts()
    {
        TipCalc tipCalculator = new TipCalc();
        Dictionary<string, decimal> mealCosts = new Dictionary<string, decimal>
        {
            {"Koushik", 65.0m},
            {"Krishna", 45.0m},
            {"Justin", 50.0m}
        };
        float tipPercent = 10.0f;
        Dictionary<string, decimal> expectedTipAmounts = new Dictionary<string, decimal>
        {
            {"Koushik", 6.5m},
            {"Krishna", 4.5m},
            {"Justin", 5m}
        };
        Dictionary<string, decimal> tipAmounts = tipCalculator.CalcTip(mealCosts, tipPercent);

        CollectionAssert.AreEqual(expectedTipAmounts, tipAmounts);
    }
    
}
[TestClass]
public class TipPerPersonCalcTests
{
    [TestMethod]
    public void CalcTipPerPerson_InputGivenValid_ReturnsCorrectAmount()
    {
        decimal price = 100.0m;
        int numbPatrons = 2;
        float tipPercent = 15.0f;
        decimal expectedTipPerPerson = 7.5m;

        TipPerPersonCalc calculator = new TipPerPersonCalc();

        decimal actualTipPerPerson = calculator.CalcTipPerPerson(price, numbPatrons, tipPercent);

        Assert.AreEqual(expectedTipPerPerson, actualTipPerPerson);
    }

    [TestMethod]
    public void CalcTipPerPerson_ZeroPatrons_ThrowsException()
    {
        decimal price = 100.0m;
        int numPatrons = 0;
        float tipPercent = 15.0f;

        TipPerPersonCalc calculator = new TipPerPersonCalc();

        Assert.ThrowsException<ArgumentException>(() => calculator.CalcTipPerPerson(price, numPatrons, tipPercent));
    }

    [TestMethod]
    public void CalcTipPerPerson_NegativePatrons_ThrowsException()
    {
        decimal price = 100.0m;
        int numPatrons = -2;
        float tipPercent = 15.0f;

        TipPerPersonCalc calculator = new TipPerPersonCalc();

        Assert.ThrowsException<ArgumentException>(() => calculator.CalcTipPerPerson(price, numPatrons, tipPercent));
    }    
}
}
