using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace DataAccess.Concrete.Entity_Framework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDbContext>, IRentalDal
    {
        public List<RentalDetailDTO> GetRentalDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from r in context.Rentals
                             join cs in context.Customers on r.CustomerId equals cs.CustomerId
                             join c in context.Cars on r.CarId equals c.CarId
                             join u in  context.Users on cs.UserId equals u.UserId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new RentalDetailDTO
                             {
                                 RentalId = r.RentalId,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate,
                                 CustomerFirstName=u.FirstName,
                                 CustomerLastName=u.LastName,
                                 BrandName=b.BrandName,
                                 DailyPrice=c.DailyPrice
                             };
                return result.ToList();
            }
            
        }
    }
}
