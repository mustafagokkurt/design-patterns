using System;
using System.Collections.Generic;
using System.Text;

namespace _10_unit_of_works
{
    public interface IRepository<T> where T : class
    {
        List<T> Get();
        bool Add(T model);
        bool Add<A>(A model) where A : class;
        bool Remove(T model);
        int Save();
    }
}
