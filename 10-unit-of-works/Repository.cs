using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace _10_unit_of_works
{
    public class Repository<T> : ControllerBase, IRepository<T>, IUnitOfWork where T : class
    {
        protected CompanyContext _companyContext;
        DbContextTransaction transaction = null;

        public Repository(CompanyContext companyContext)
        {
            _companyContext = companyContext;
            transaction = _companyContext.Database.BeginTransaction();
        }

        [NonAction]
        public List<T> Get() => _companyContext.Set<T>().ToList();

        [NonAction]
        public bool Add(T model)
        {
            _companyContext.Set<T>().Add(model);
            return true;
        }

        [NonAction]
        public bool Add<A>(A model) where A : class
        {
            _companyContext.Set<A>().Add(model);
            return true;
        }

        [NonAction]
        public bool Remove(T model)
        {
            _companyContext.Set<T>().Remove(model);
            return true;
        }

        [NonAction]
        public int Save() => _companyContext.SaveChanges();

        [NonAction]
        public bool Commit(bool state = true)
        {
            Save();
            if (state)
                transaction.Commit();
            else
                transaction.Rollback();

            Dispose();
            return true;
        }
        public void Dispose()
        {
            _companyContext.Dispose();
        }
    }
}
