using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemModels
{
    public class ProductPurchaseOrderbook : BaseModel
    {
        public string ProductName { get; set; }

        public string? ProductCategory { get; set; }

        public string? PurchasedByVendor { get; set; }

        public string? UnitValue { get; set; }
        public string? Unit { get; set; }

        public int Quantity { get; set; }

        public long? BuyingPrice { get; set; }
    }
}
