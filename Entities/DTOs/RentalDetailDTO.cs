using Core.Entities;
using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDTO :IDto
    {
        public int RentalId { get; set; }
        public string BrandName { get; set; }
        public int MyProperty { get; set; }
        public string UserName { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
