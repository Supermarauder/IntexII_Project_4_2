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

        public IActionResult AddProduct()
        {
            return View();
        }
        public IActionResult AllOrders()
        {
            return View();
        }
        public IActionResult AllProducts()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult AdminIndex()
        {
            return View();
        }
        public IActionResult UpdateProduct()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Confirmation0()
        {
            return View();
        }
        public IActionResult Confirmation1()
        {
            return View();
        }
        public IActionResult RegistrationSuccessful()
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
        public IActionResult ViewProducts()
        {
            return View();
        }


    }
}
