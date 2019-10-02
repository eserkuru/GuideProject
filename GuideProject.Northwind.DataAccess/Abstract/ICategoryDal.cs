using GuideProject.Core.DataAccess;
using GuideProject.Northwind.Entities;

namespace GuideProject.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom Operations
    }
}