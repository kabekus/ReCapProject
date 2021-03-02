using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _ırentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _ırentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            _ırentalDal.Add(rental);
            return new SuccessResult(Messages.Rented);
        }

        public IResult Delete(Rental rental)
        {
            _ırentalDal.Delete(rental);
            return new SuccessResult(Messages.DeletingComplete);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_ırentalDal.GetAll());
        }

        public IDataResult<Rental> GetByRentalId(int id)
        {
            return new SuccessDataResult<Rental>(_ırentalDal.Get(r=>r.RentalId==id));
        }

        public IDataResult<List<RentalDetailDTO>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDTO>>(_ırentalDal.GetRentalDetails());
        }

        public IResult Update(Rental rental)
        {
            _ırentalDal.Equals(rental);
            return new SuccessResult(Messages.UpdatingComplete);
        }
    }
}
