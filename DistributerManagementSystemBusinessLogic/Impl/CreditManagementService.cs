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
    public class CreditManagementService : ICreditManagementService
    {
        private readonly ICreditManagementRepository CreditManagementRepository;

        public CreditManagementService(ICreditManagementRepository CreditManagementRepository)
        {
            this.CreditManagementRepository = CreditManagementRepository;
        }

        public void Add(CreditManagement entity)
        {
            try
            {
                CreditManagementRepository.Add(entity);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public void Delete(CreditManagement entity)
        {
            entity.IsActive = false;
            CreditManagementRepository.Update(entity);
        }

        public IQueryable<CreditManagement> FindBy(Expression<Func<CreditManagement, bool>> predicate)
        {
            return CreditManagementRepository.FindBy(predicate).Where(x => x.IsActive == true);
        }

        public IQueryable<CreditManagement> GetAll()
        {
            return CreditManagementRepository.GetAll().Where(x => x.IsActive == true);
        }

        public void Save()
        {
            CreditManagementRepository.Save();
        }

        public void Update(CreditManagement entity)
        {
            try
            {
                var CreditManagement = this.FindBy(x => x.TempId == entity.TempId).SingleOrDefault();

                CreditManagement.IsActive = false;
                CreditManagement.UpdatedBy = "User"; //change this to whoever is logged in
                CreditManagement.DateUpdated = DateTime.Now;
                CreditManagementRepository.Update(CreditManagement);

                entity.Id = Guid.NewGuid();
                CreditManagementRepository.Add(entity);

            }
            catch (Exception e)
            {

                throw e.InnerException;
            }


        }
    }
}
