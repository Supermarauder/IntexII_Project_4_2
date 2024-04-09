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

        public IActionResult Index()
        {

            return View();
        }


        public IActionResult About()
        {
            return View();
        }
        public IActionResult CartSummary()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ProductDetail()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult ViewProducts(int pageNum)
        {
            int pageSize = 5;

            // Ensure pageNum is at least 1
            pageNum = Math.Max(1, pageNum);

            // Calculate the number of products to skip
            int skipAmount = (pageNum - 1) * pageSize;

            var ProductList = new ProductListViewModel
            {
                Products = _repo.Products
                    .OrderBy(x => x.Name)
                    .Skip(skipAmount)  // Use the safely calculated skip amount
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


    }
}
