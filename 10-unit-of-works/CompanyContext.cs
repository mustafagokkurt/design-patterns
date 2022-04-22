using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;


namespace _10_unit_of_works
{    
    public class CompanyContext : DbContext
    {
        public CompanyContext()
        {

        }
        // Entities                
        public DbSet<Office> offices { get; set; }
    }

    public class Office
    {

    }
}
