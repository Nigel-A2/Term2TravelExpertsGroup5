using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdministrationGUI.Models
{
    public partial class Product
    {

        public static readonly int MAX_NAME_LENGTH = 50;

        public string GetDisplayText(string sep)
        {
            return ProductId + sep + ProdName;
        }
    }
}
