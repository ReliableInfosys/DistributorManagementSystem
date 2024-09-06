using DistributerManagementSystemBusinessLogic.Interface;
using DistributerManagementSystemModels;
using DistributerManagementSystemRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemBusinessLogic.Impl
{
    public class OrderbookService : IOrderbookService
    {
        private readonly IOrderbookRepository orderbookRepository;

        public OrderbookService(IOrderbookRepository orderbookRepository)
        {
            this.orderbookRepository = orderbookRepository;
        }

        public void Add(Orderbook entity)
        {
            try
            {
                orderbookRepository.Add(entity);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public void Delete(Orderbook entity)
        {
            entity.IsActive = false;
            orderbookRepository.Update(entity);
        }

        public IQueryable<Orderbook> FindBy(Expression<Func<Orderbook, bool>> predicate)
        {
            return orderbookRepository.FindBy(predicate).Where(x=>x.IsActive == true);
        }

        public IQueryable<Orderbook> GetAll()
        {
            return orderbookRepository.GetAll().Where(x=>x.IsActive == true);
        }

        public void Save()
        {
            orderbookRepository.Save();
        }

        public void EditOrder(Orderbook entity)
        {
            try
            {
                var orderbook = this.FindBy(x => x.TempId == entity.TempId).SingleOrDefault();
                orderbookRepository.Update(orderbook);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Update(Orderbook entity)
        {
            try
            {
                var orderbook = this.FindBy(x => x.TempId == entity.TempId).SingleOrDefault();

                orderbook.IsActive = false;
                orderbook.UpdatedBy = "User"; //change this to whoever is logged in
                orderbook.DateUpdated = DateTime.Today;
                orderbookRepository.Update(orderbook);

                entity.Id = Guid.NewGuid();
                orderbookRepository.Add(entity);

            }
            catch (Exception e)
            {

                throw e.InnerException;
            }

            
        }
    }
}
