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
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository VendorRepository;

        public VendorService(IVendorRepository VendorRepository)
        {
            this.VendorRepository = VendorRepository;
        }

        public void Add(Vendor entity)
        {
            try
            {
                VendorRepository.Add(entity);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public void Delete(Vendor entity)
        {
            entity.IsActive = false;
            VendorRepository.Update(entity);
        }

        public IQueryable<Vendor> FindBy(Expression<Func<Vendor, bool>> predicate)
        {
            return VendorRepository.FindBy(predicate).Where(x => x.IsActive == true);
        }

        public IQueryable<Vendor> GetAll()
        {
            return VendorRepository.GetAll().Where(x => x.IsActive == true);
        }

        public void Save()
        {
            VendorRepository.Save();
        }

        public void Update(Vendor entity)
        {
            try
            {
                var Vendor = this.FindBy(x => x.TempId == entity.TempId).SingleOrDefault();

                Vendor.IsActive = false;
                Vendor.UpdatedBy = "User"; //change this to whoever is logged in
                Vendor.DateUpdated = DateTime.Now;
                VendorRepository.Update(Vendor);

                entity.Id = Guid.NewGuid();
                VendorRepository.Add(entity);

            }
            catch (Exception e)
            {

                throw e.InnerException;
            }


        }
    }
}
