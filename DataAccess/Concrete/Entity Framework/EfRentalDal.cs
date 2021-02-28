using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rentals, CarDbContext>, IRentalDal
    {
        public List<RentalDetailDTO> GetRentalDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers on rental.CustomerId equals customer.CustomerId
                             join u in context.Users on customer.UserId equals user.UserId
                             join cr in context.Cars on rental.CarId equals car.CarId
                             select new RentalDetailDto { };
                             
                return result.ToList();
            }
        }
    }
}
