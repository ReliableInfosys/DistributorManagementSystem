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
    public class RetailerService : IRetailerService
    {
        private readonly IRetailerRepository RetailerRepository;

        public RetailerService(IRetailerRepository RetailerRepository)
        {
            this.RetailerRepository = RetailerRepository;
        }

        public void Add(Retailer entity)
        {
            try
            {
                RetailerRepository.Add(entity);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public void Delete(Retailer entity)
        {
            entity.IsActive = false;
            RetailerRepository.Update(entity);
        }

        public IQueryable<Retailer> FindBy(Expression<Func<Retailer, bool>> predicate)
        {
            return RetailerRepository.FindBy(predicate).Where(x => x.IsActive == true);
        }

        public IQueryable<Retailer> GetAll()
        {
            return RetailerRepository.GetAll().Where(x => x.IsActive == true);
        }

        public void Save()
        {
            RetailerRepository.Save();
        }

        public void Update(Retailer entity)
        {
            try
            {
                var Retailer = this.FindBy(x => x.TempId == entity.TempId).SingleOrDefault();

                Retailer.IsActive = false;
                Retailer.UpdatedBy = "User"; //change this to whoever is logged in
                Retailer.DateUpdated = DateTime.Now;
                RetailerRepository.Update(Retailer);

                entity.Id = Guid.NewGuid();
                RetailerRepository.Add(entity);

            }
            catch (Exception e)
            {

                throw e.InnerException;
            }


        }
    }
}
