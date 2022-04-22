using System;
using System.Collections.Generic;
using System.Text;

namespace _10_unit_of_works
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit(bool state = true);
    }
}
