using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdministrationData.Models
{
    public partial class ProductsSupplier
    {
        public string GetDisplayText(string sep)
        {
            return ProductSupplierId + sep + Product.ProdName.PadRight(30) + Supplier.SupName;
        }
    }
}
