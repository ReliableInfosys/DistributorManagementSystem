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
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository UsersRepository;

        public UsersService(IUsersRepository UsersRepository)
        {
            this.UsersRepository = UsersRepository;
        }

        public void Add(Users entity)
        {
            try
            {
                UsersRepository.Add(entity);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public void Delete(Users entity)
        {
            entity.IsActive = false;
            UsersRepository.Update(entity);
        }

        public IQueryable<Users> FindBy(Expression<Func<Users, bool>> predicate)
        {
            return UsersRepository.FindBy(predicate).Where(x => x.IsActive == true);
        }

        public IQueryable<Users> GetAll()
        {
            return UsersRepository.GetAll().Where(x => x.IsActive == true);
        }

        public void Save()
        {
            UsersRepository.Save();
        }

        public void Update(Users entity)
        {
            try
            {
                var Users = this.FindBy(x => x.TempId == entity.TempId).SingleOrDefault();

                Users.IsActive = false;
                Users.UpdatedBy = "User"; //change this to whoever is logged in
                Users.DateUpdated = DateTime.Now;
                UsersRepository.Update(Users);

                entity.Id = Guid.NewGuid();
                UsersRepository.Add(entity);

            }
            catch (Exception e)
            {

                throw e.InnerException;
            }


        }
    }
}
