using DistributerManagementSystemModels;
using DistributerManagementSystemRepository.Common;
using DistributerManagementSystemRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemRepository.Impl
{
    public class ProductsRepository : GenericRepository<Products, DistributerManagementSystemContext> , IProductsRepository
    {
        public ProductsRepository(DistributerManagementSystemContext context):base(context)
        {
                
        }
    }
}
