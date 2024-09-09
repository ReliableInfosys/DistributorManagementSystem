using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemModels
{
    public class ProductsCategory: BaseModel
    {
        
        public string Name { get; set; }
        public decimal GSTPercentage { get; set; }
        
    }
}
