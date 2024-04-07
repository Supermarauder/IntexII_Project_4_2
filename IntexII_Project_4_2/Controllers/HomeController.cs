using IntexII_Project_4_2.Models;
using IntexII_Project_4_2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IntexII_Project_4_2.Controllers
{
    public class HomeController : Controller
    {
        private IIntexProjectRepository _repo;
        public HomeController(IIntexProjectRepository temp) 
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 2;

            var ProductList = new ProductListViewModel
            {
                Products = _repo.Products
                .OrderBy(x => x.Name)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Products.Count()
                }

            };

            return View(ProductList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
