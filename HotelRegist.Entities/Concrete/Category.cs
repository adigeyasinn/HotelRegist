﻿using HotelRegist.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegist.Entities.Concrete
{
   public class Category:IEntity
    {
        public int Id { get; set; }
        public int CategoryName { get; set; }

    }
}
