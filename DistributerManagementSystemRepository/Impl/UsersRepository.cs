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
    public class UsersRepository: GenericRepository<Users,DistributerManagementSystemContext> , IUsersRepository
    {
        public UsersRepository(DistributerManagementSystemContext context):base(context)
        {
                
        }

        public static void Add(ProductsCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
