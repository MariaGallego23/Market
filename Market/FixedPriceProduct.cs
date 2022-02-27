using Market;

namespace Market
{

    public class FixedPriceProduct : Product
    {

        public override decimal GetValueToPay()
        {
            return (decimal)Tax * Price + Price;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tValue................: {$"{GetValueToPay():C2}",18}";

        }
    }
}