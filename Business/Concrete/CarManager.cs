﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
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

        [SecuredOperation("car.add")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
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
            if (DateTime.Now.Hour == 23)
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
        public IDataResult<List<Car>> GetCarsByCarId(int id)
        {
            return new SuccessDataResult<List<Car>>(_ıcarDal.GetAll(a => a.CarId == id));
        }

        public IResult Update(Car car)
        {
            _ıcarDal.Update(car);
            return new SuccessResult(Messages.UpdatingComplete);
        }
    }
}
