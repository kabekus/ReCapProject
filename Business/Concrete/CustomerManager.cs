using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {

        ICustomerDal _ıcustomerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _ıcustomerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _ıcustomerDal.Add(customer);
            return new SuccessResult(Messages.AddingComplete);
        }

        public IResult Delete(Customer customer)
        {
            _ıcustomerDal.Delete(customer);
            return new SuccessResult(Messages.DeletingComplete);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_ıcustomerDal.GetAll(),Messages.ListingComplete);
        }

        public IDataResult<Customer> GetByCustomerId(int id)
        {
            return new SuccessDataResult<Customer>(_ıcustomerDal.Get(c => c.CustomerId == id));
        }

        public IResult Update(Customer customer)
        {
            _ıcustomerDal.Equals(customer);
            return new SuccessResult(Messages.UpdatingComplete);
        }
    }
}
