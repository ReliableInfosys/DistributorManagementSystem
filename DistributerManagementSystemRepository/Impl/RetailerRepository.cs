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
    public class RetailerRepository : GenericRepository<Retailer, DistributerManagementSystemContext>, IRetailerRepository
    {
        public RetailerRepository(DistributerManagementSystemContext context) : base(context)
        {
                
        }
    }
}
