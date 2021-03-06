﻿using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           //CarTest();
            BrandTest();
            //AraçEkleme();


        }

       
            private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
                var result = brandManager.GetAll();
                if (result.Success==true)
                {
                    foreach (var brand in result.Data)
                    {
                        Console.WriteLine(brand.BrandName);
                    }
                }

                Console.WriteLine(result.Message);
               
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " renk: " + car.ColorName + " Fiyat:  " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
