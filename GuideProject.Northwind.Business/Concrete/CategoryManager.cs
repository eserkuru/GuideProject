using System.Collections.Generic;
using GuideProject.Northwind.Business.Abstract;
using GuideProject.Northwind.DataAccess.Abstract;
using GuideProject.Northwind.Entities;

namespace GuideProject.Northwind.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
