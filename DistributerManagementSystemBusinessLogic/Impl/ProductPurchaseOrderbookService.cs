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
    public class ProductPurchaseOrderbookService : IProductPurchaseOrderbookService
    {
        private readonly IProductPurchaseOrderbookRepository ProductPurchaseOrderbookRepository;

        public ProductPurchaseOrderbookService(IProductPurchaseOrderbookRepository ProductPurchaseOrderbookRepository)
        {
            this.ProductPurchaseOrderbookRepository = ProductPurchaseOrderbookRepository;
        }

        public void Add(ProductPurchaseOrderbook entity)
        {
            try
            {
                ProductPurchaseOrderbookRepository.Add(entity);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public void Delete(ProductPurchaseOrderbook entity)
        {
            entity.IsActive = false;
            ProductPurchaseOrderbookRepository.Update(entity);
        }

        public IQueryable<ProductPurchaseOrderbook> FindBy(Expression<Func<ProductPurchaseOrderbook, bool>> predicate)
        {
            return ProductPurchaseOrderbookRepository.FindBy(predicate).Where(x => x.IsActive == true);
        }

        public IQueryable<ProductPurchaseOrderbook> GetAll()
        {
            return ProductPurchaseOrderbookRepository.GetAll().Where(x => x.IsActive == true);
        }

        public void Save()
        {
            ProductPurchaseOrderbookRepository.Save();
        }

        public void Update(ProductPurchaseOrderbook entity)
        {
            try
            {
                var ProductPurchaseOrderbook = this.FindBy(x => x.TempId == entity.TempId).SingleOrDefault();

                ProductPurchaseOrderbook.IsActive = false;
                ProductPurchaseOrderbook.UpdatedBy = "User"; //change this to whoever is logged in
                ProductPurchaseOrderbook.DateUpdated = DateTime.Now;
                ProductPurchaseOrderbookRepository.Update(ProductPurchaseOrderbook);

                entity.Id = Guid.NewGuid();
                ProductPurchaseOrderbookRepository.Add(entity);

            }
            catch (Exception e)
            {

                throw e.InnerException;
            }


        }
    }
}
