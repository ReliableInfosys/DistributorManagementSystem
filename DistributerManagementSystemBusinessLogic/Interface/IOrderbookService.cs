using DistributerManagementSystemBusinessLogic.Common;
using DistributerManagementSystemModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemBusinessLogic.Interface
{
    public interface IOrderbookService : IGenericService<Orderbook>
    {
        void EditOrder(Orderbook entity);

        //add business logic here
    }
}
