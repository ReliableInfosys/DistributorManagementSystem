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
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository ProductCategoryRepository;

        public ProductCategoryService(IProductCategoryRepository ProductCategoryRepository)
        {
            this.ProductCategoryRepository = ProductCategoryRepository;
        }

        public void Add(ProductsCategory entity)
        {
            try
            {
                ProductCategoryRepository.Add(entity);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public void Delete(ProductsCategory entity)
        {
            entity.IsActive = false;
            ProductCategoryRepository.Update(entity);
        }

        public IQueryable<ProductsCategory> FindBy(Expression<Func<ProductsCategory, bool>> predicate)
        {
            return ProductCategoryRepository.FindBy(predicate).Where(x => x.IsActive == true);
        }

        public IQueryable<ProductsCategory> GetAll()
        {
            return ProductCategoryRepository.GetAll().Where(x => x.IsActive == true);
        }

        public void Save()
        {
            ProductCategoryRepository.Save();
        }

        public void Update(ProductsCategory entity)
        {
            try
            {
                var ProductCategory = this.FindBy(x => x.TempId == entity.TempId).SingleOrDefault();

                ProductCategory.IsActive = false;
                ProductCategory.UpdatedBy = "User"; //change this to whoever is logged in
                ProductCategory.DateUpdated = DateTime.Now;
                ProductCategoryRepository.Update(ProductCategory);

                entity.Id = Guid.NewGuid();
                ProductCategoryRepository.Add(entity);

            }
            catch (Exception e)
            {

                throw e.InnerException;
            }


        }
    }
}
