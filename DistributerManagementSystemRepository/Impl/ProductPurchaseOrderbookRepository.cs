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
    public class ProductPurchaseOrderbookRepository : GenericRepository<ProductPurchaseOrderbook, DistributerManagementSystemContext>, IProductPurchaseOrderbookRepository
    {
        public ProductPurchaseOrderbookRepository(DistributerManagementSystemContext context) : base(context)
        {

        }
    }
}
