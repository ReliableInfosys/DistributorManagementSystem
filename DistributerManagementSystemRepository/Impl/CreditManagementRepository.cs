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
    public class CreditManagementRepository : GenericRepository<CreditManagement,DistributerManagementSystemContext> , ICreditManagementRepository
    {
        public CreditManagementRepository(DistributerManagementSystemContext context) : base(context)
        {
            
        }
    }
}
