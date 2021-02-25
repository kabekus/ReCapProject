using Business.Abstract;
using Business.Constants;
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
        public IResult Add(Rentals rental)
        {
            if (rental.ReturnDate==null && rental.ReturnDate > DateTime.Now)
            {
                return new ErrorResult(Messages.DeliveryError);
            }
            _ırentalDal.Add(rental);
            return new SuccessResult(Messages.Rented);
        }

        public IResult Delete(Rentals rental)
        {
            _ırentalDal.Delete(rental);
            return new SuccessResult(Messages.DeletingComplete);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_ırentalDal.GetAll());
        }

        public IDataResult<Rentals> GetByRentalId(int id)
        {
            return new SuccessDataResult<Rentals>(_ırentalDal.Get(r=>r.RentalId==id));
        }

        public IDataResult<List<RentalDetailDTO>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDTO>>(_ırentalDal.GetRentalDetails());
        }

        public IResult Update(Rentals rental)
        {
            _ırentalDal.Equals(rental);
            return new SuccessResult(Messages.UpdatingComplete);
        }
    }
}
