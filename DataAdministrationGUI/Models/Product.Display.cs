using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdministrationGUI.Models
{
    public partial class Product
    {

        public string GetDisplayText(string sep)
        {
            return ProductId + sep + ProdName;
        }
    }
}
