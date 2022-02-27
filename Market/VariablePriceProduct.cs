using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    using Market;

    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }


        public override decimal GetValueToPay()
        {
            decimal TotalSV = (decimal)Quantity * Price;
            return (decimal)Tax * TotalSV + TotalSV;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tMeasurement..........: {$"{Measurement}",18}" +
                $"\n\tQuantity.............: {$"{Quantity}",18}" +
                $"\n\tValue................: {$"{GetValueToPay():C2}",18}";



        }
    }
}