﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DistributerManagementSystemBusinessLogic.Common
{
    public interface IGenericService<T> where T : class
    {
        IQueryable<T> GetAll();

        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

        void Add(T entity);


        void Delete(T entity);

        void Update(T entity);

        void Save();
    }
}
