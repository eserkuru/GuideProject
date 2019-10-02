using System.Collections.Generic;
using GuideProject.Northwind.Entities;

namespace GuideProject.Northwind.AspNetCoreUI.Models
{
    public class ProductListViewModel
    {
        public int CurrentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public List<Product> Products { get; internal set; }
    }
}
