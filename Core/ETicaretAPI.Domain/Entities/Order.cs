﻿using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Order:BaseEntity
    {
        public string description { get; set; }
        public string address { get; set; }

        public ICollection<Product> Products { get; set; }
        public Customer customer { get; set; }
    }
}
