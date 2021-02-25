using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customers>> GetAll();
        IDataResult<Customers> GetByCustomerId(int id);
        IResult Add(Customers customer);
        IResult Delete(Customers customer);
        IResult Update(Customers customer);
    }
}
