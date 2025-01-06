using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceProjet
{
    public interface IDiscountable
    {
        decimal ApplyDiscount(decimal pourcentage);
    }
}