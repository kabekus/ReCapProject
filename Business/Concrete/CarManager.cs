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
    public class CarManager : ICarService
    {
        ICarDal _ıcarDal;
        public CarManager(ICarDal carDal)
        {
            _ıcarDal = carDal;
        }

       

        public IResult Add(Car car)
        {
            if (car.Description.Length < 2 && car.DailyPrice < 0)
            {

                return new ErrorResult(Messages.DescriptionInvalid);
            }
                _ıcarDal.Add(car);
                
               return new SuccessResult(Messages.AddingComplete);
            
        }

        public IResult Delete(Car car)
        {
            _ıcarDal.Delete(car);
            return new SuccessResult(Messages.DeletingComplete);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==13)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintanceTime);
            }
            return new SuccessDataResult<List<Car>>(_ıcarDal.GetAll(),Messages.ListingComplete );
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_ıcarDal.Get(c=>c.CarId == id));
        }

        public IDataResult<List<CarDetailDTO>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDTO>>(_ıcarDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_ıcarDal.GetAll(b => b.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_ıcarDal.GetAll(c => c.ColorId == id));
        }

        public IResult Update(Car car)
        {
            _ıcarDal.Update(car);
            return new SuccessResult(Messages.UpdatingComplete);
        }

        
    }
}
