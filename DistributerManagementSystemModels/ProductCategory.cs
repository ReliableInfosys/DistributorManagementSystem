using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemModels
{
    public class ProductCategory: BaseModel
    {       

        public decimal GSTPercentage { get; set; }
        public string Name { get; set; }
    }
}
