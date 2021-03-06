﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByCarId(int id);
        IDataResult<List<CarDetailDTO>> GetCarDetails();
        IDataResult<Car> GetById(int id);
        IResult Add(Car car); // bu fonksiyonlara bak !!!!
        IResult Delete(Car car);
        IResult Update(Car car);
    }

}
