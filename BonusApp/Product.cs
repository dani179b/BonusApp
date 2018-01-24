namespace BonusApp
{
    public class Product
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public Product(string name, double value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}