using System;
using System.Collections.Generic;
using System.Text;

namespace _11_decorator
{
    interface IRepository<T>
    {
        T Get(int id);
        T GetAll();
        void Add(T model);
        void Delete(T model);
        void Update(T model);
    }
}
