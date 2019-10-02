using System.Collections.Generic;
using GuideProject.Northwind.Entities;

namespace GuideProject.Northwind.AspNetCoreUI.Models
{
    public class ProductAddViewModel
    {
        public List<Category> Categories { get; internal set; }
        public Product Product { get; set; }
    }
}
