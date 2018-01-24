using System.Collections.Generic;

namespace BonusApp
{
    public class Order
    {
        private double _valueOfProducts;
        private double _bonusOfProduct;

        static readonly Bonuses B = new Bonuses();
        public readonly List<Product> ListOfProducts = new List<Product>();

        public DgBonusProvider BonusProvider { get; set; }
        public DgBonusProvider BonusProviderTen = B.TenPercent;
        public DgBonusProvider BonusProviderFlatFive = B.FlatTwoIfAmountMoreThanFive;

        

        public void AddProduct(Product product)
        {
            ListOfProducts.Add(product);
        }

        public double GetValueOfProduct()
        {
            double valueOfProducts = 0;
            foreach (Product product in ListOfProducts)
            {
                valueOfProducts += product.Value;
            }
            return valueOfProducts;
        }
        public double GetBonus()
        {
            double bonusOfProduct = 0;
            foreach (Product product in ListOfProducts)
            {
                bonusOfProduct += BonusProviderFlatFive(product.Value) + BonusProviderTen(product.Value);
            }
            return bonusOfProduct;
        }

        public double GetTotalprice()
        {
            double totalPrice = GetValueOfProduct() - GetBonus();
            return totalPrice;
        }
    }
}