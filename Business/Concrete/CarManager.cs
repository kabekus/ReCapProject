using Business.Abstract;
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
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _ıcarDal.Add(car);
                return new ErrorResult("Açılama en az 2 karakter ve günlük ücret 0dan büyük olmalı");
            }
            
                return new SuccessResult();
            

        }

        public void Delete(Car car)
        {
            _ıcarDal.Delete(car);
            Console.WriteLine("Silme başarılı");
        }

        public List<Car> GetAll()
        {
            return _ıcarDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _ıcarDal.Get(c=>c.CarId == id);
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            return _ıcarDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _ıcarDal.GetAll(b => b.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _ıcarDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _ıcarDal.Update(car);
            Console.WriteLine("Güncelleme başarılı");
        }

        
    }
}
