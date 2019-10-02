using System.Collections.Generic;
using GuideProject.Northwind.Entities;

namespace GuideProject.Northwind.AspNetCoreUI.Models
{
    public class ProductUpdateViewModel
    {
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}