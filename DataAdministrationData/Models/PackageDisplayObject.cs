using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdministrationData.Models
{
    public class PackageDisplayObject
    {
        public int PackageId { get; set; }
        public int ProductSupplierId { get; set; }
        public string PackageName { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }

        public PackageDisplayObject() { }

        public PackageDisplayObject(int packageId, int productSupplierId, string packageName, string productName, string supplierName)
        {
            PackageId = packageId;
            ProductSupplierId = productSupplierId;
            PackageName = packageName;
            ProductName = productName;
            SupplierName = supplierName;
        }

        public string GetDisplayText(string sep)
        {
            return PackageName.PadRight(30) + sep + ProductName.PadRight(30) + sep + SupplierName.PadRight(30);
        }

        public string displayProductAndSupplier(string sep)
        {
            return ProductName + sep + SupplierName;
        }

    }
}
