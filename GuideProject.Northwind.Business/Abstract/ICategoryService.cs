using System.Collections.Generic;
using GuideProject.Northwind.Entities;

namespace GuideProject.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}