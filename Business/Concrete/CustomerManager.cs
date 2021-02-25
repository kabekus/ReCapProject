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

        public IResult Add(Customers customer)
        {
            _ıcustomerDal.Add(customer);
            return new SuccessResult(Messages.AddingComplete);
        }

        public IResult Delete(Customers customer)
        {
            _ıcustomerDal.Delete(customer);
            return new SuccessResult(Messages.DeletingComplete);
        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_ıcustomerDal.GetAll(),Messages.ListingComplete);
        }

        public IDataResult<Customers> GetByCustomerId(int id)
        {
            return new SuccessDataResult<Customers>(_ıcustomerDal.Get(c => c.CutomerId == id));
        }

        public IResult Update(Customers customer)
        {
            _ıcustomerDal.Equals(customer);
            return new SuccessResult(Messages.UpdatingComplete);
        }
    }
}
