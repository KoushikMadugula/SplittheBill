namespace SplittheBill;

public class TipCalc
{
    public Dictionary<string, decimal> CalcTip(Dictionary<string, decimal> meals, float tipPercent)
    {
    decimal totalCost = meals.Values.Sum();
    decimal totalTip = totalCost * (decimal) (tipPercent/100);

    var tipByPerson = new Dictionary<string, decimal>();
    foreach (var (name, cost) in meals)
    {
        decimal weight = cost / totalCost;
        decimal individualTip = totalTip * weight;
        tipByPerson.Add(name, Math.Round(individualTip, 2));
    }

    return tipByPerson;
    }
}
