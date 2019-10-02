using System;
using System.Linq;
using GuideProject.Northwind.AspNetCoreUI.Models;
using GuideProject.Northwind.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GuideProject.Northwind.AspNetCoreUI.Controllers
{
    public class ProductController:Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int page=1,int category=0)
        {
            const int pageSize = 10;
            var products = _productService.GetByCategory(category);
            ProductListViewModel model =new ProductListViewModel
            {
                Products = products.Skip((page-1)*pageSize).Take(pageSize).ToList(),
                PageCount= (int)Math.Ceiling(products.Count/(double)pageSize),
                PageSize =pageSize,
                CurrentCategory = category,
                CurrentPage =page
            };
            return View(model);
        }

    }
}
