using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

       

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _ıcarDal.Add(car);
                Console.WriteLine("Araç eklendi");
            }
            else
            {
                Console.WriteLine("Ekleme başarısız");
            }
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
