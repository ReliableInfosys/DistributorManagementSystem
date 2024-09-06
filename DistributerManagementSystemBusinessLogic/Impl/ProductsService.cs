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
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository ProductsRepository;

        public ProductsService(IProductsRepository ProductsRepository)
        {
            this.ProductsRepository = ProductsRepository;
        }

        public void Add(Products entity)
        {
            try
            {
                ProductsRepository.Add(entity);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public void Delete(Products entity)
        {
            entity.IsActive = false;
            ProductsRepository.Update(entity);
        }

        public IQueryable<Products> FindBy(Expression<Func<Products, bool>> predicate)
        {
            return ProductsRepository.FindBy(predicate).Where(x => x.IsActive == true);
        }

        public IQueryable<Products> GetAll()
        {
            return ProductsRepository.GetAll().Where(x => x.IsActive == true);
        }

        public void Save()
        {
            ProductsRepository.Save();
        }

        public void Update(Products entity)
        {
            try
            {
                var Products = this.FindBy(x => x.TempId == entity.TempId).SingleOrDefault();

                Products.IsActive = false;
                Products.UpdatedBy = "User"; //change this to whoever is logged in
                Products.DateUpdated = DateTime.Now;
                ProductsRepository.Update(Products);

                entity.Id = Guid.NewGuid();
                ProductsRepository.Add(entity);

            }
            catch (Exception e)
            {

                throw e.InnerException;
            }


        }
    }
}
