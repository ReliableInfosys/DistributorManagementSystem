using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;  
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemModels
{
    public class Products : BaseModel
    {
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Product Description")]
        public string? ProductDescription { get; set; }
        [DisplayName("Select Category")]
     
        public string ProductCategory { get; set; }

        public string? Unit { get; set; }

        public string? Size { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal GSTOnProcut { get; set; }

        public long? BuyingPrice { get; set; }

        public long? Price { get; set; }
    }
}
