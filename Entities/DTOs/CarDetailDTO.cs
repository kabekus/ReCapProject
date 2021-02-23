﻿using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDTO: IDto
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public  int ColorId { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
