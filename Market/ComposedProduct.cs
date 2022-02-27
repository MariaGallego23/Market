using Market;

public class ComposedProduct : Product
{
    public double Discount { get; set; }
    public List<Product> Products { get; set; }

    public override decimal GetValueToPay()
    {
        decimal acumulator = 0;
        for (int i = 0; i < Products.Count; i++)
        {
            acumulator = acumulator + Products[i].GetValueToPay();
        }
        return acumulator - (acumulator * (decimal)Discount);
    }
    public override string ToString()
    {
        string products = "";
        for (int i = 0; i < Products.Count; i++)
        {
            products = products + Products[i].Description + ", ";
        }

        return $"{Id} - {Description}" +
                 $"\n\tProducts.............: {$"{products}",18}" +
                 $"\n\tDiscount.............: {$"{Discount:P2}",18}" +
                 $"\n\tValue................: {$"{GetValueToPay():C2}",18}";
    }
}