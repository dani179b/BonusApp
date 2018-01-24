namespace BonusApp
{
    public delegate double DgBonusProvider(double amount);
    public class Bonuses
    {
        public double TenPercent(double amount)
        {
            double tenOfAmount = amount * 0.10;
            return tenOfAmount;
        }

        public double FlatTwoIfAmountMoreThanFive(double amount)
        {
            return amount > 5 ? 2.0 : 0.0;
        }
    }
}