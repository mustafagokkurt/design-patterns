using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace _10_unit_of_works
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : Repository<Office>
    {
        public CompanyController(CompanyContext companyContext) : base(companyContext)
        { }
        public bool DatabaseBusiness()
        {
            Add(new Office());
            Add(new Office());
            Add(new Office());
            Add(new Office());            

            //

            Commit();

            return true;
        }
    }
}
