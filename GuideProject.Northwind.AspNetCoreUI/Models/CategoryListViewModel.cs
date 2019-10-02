using System.Collections.Generic;
using GuideProject.Northwind.Entities;

namespace GuideProject.Northwind.AspNetCoreUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
        public int CurrentCategory { get; internal set; }
    }
}
