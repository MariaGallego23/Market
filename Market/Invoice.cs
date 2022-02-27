
namespace Market
{
    public class Invoice : Ipay
    {
        private List<Product> _products = new();

        public Invoice()
        { }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public override string ToString()
        {
            string products = "";
            for (int i = 0; i < _products.Count; i++)
            {
                products = products + _products[i].ToString() + "\n\t ";

            }

            return $"RECEIPT" +
                "\n-----------------------------------------------------" +
                     $"\n\tProducts.............: {$"{products}",18}" +
                     $"\n\t                           ==============" +
                     $"\n\tTOTAL................: {$"{GetValueToPay():C2}",18}";

        }

        public decimal GetValueToPay()
        {
            decimal acumulator = 0;
            for (int i = 0; i < _products.Count; i++)
            {
                acumulator = acumulator + _products[i].GetValueToPay();
            }
            return acumulator;
        }






    }
}