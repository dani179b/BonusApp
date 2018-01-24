using System.Collections.Generic;

namespace BonusApp
{
    public class Order
    {
        private double _valueOfProducts;
        private double _bonusOnProduct;

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
            foreach (Product product in ListOfProducts)
            {
                _valueOfProducts += product.Value;
            }
            return _valueOfProducts;
        }
        public double GetBonus()
        {   
            foreach (Product product in ListOfProducts)
            {
                _bonusOnProduct += BonusProviderTen(product.Value);
                _bonusOnProduct += BonusProviderFlatFive(product.Value);

            }
            return _bonusOnProduct;
        }

        public double GetTotalprice()
        {
            double totalPrice = _valueOfProducts - _bonusOnProduct;
            return totalPrice;
        }
    }
}