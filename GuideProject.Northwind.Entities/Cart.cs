﻿using System.Collections.Generic;
using System.Linq;
using GuideProject.Northwind.Entities.Abstract;

namespace GuideProject.Northwind.Entities
{
    public class Cart : BaseEntity
    {
        public Cart()
        {
            CartLines=new List<CartLine>();
        }
        public List<CartLine> CartLines { get; set; }

        public decimal Total
        {
            get { return CartLines.Sum(c => c.Product.UnitPrice*c.Quantity); }
        }
    }
}