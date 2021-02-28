using DataAccess.Abstract;
using Entities.Concrete;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.EntityFramework;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customers, CarDbContext>, ICustomerDal
    {
       
    }
}
