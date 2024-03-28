﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int  ProductId { get; set; }
        public int   OrderId { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}
