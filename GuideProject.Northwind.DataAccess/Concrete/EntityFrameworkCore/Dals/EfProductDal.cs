﻿using GuideProject.Core.DataAccess.EntityFrameworkCore;
using GuideProject.Northwind.DataAccess.Abstract;
using GuideProject.Northwind.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using GuideProject.Northwind.Entities;

namespace GuideProject.Northwind.DataAccess.Concrete.EntityFrameworkCore.Dals
{
    public class EfProductDal:EfEntityRepositoryBase<Product,Northwind2Context>,IProductDal
    {

    }
}
