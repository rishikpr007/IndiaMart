using IndiaMart.Models;
using IndiaMart.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndiaMart.Controllers
{
    public class ProductController : Controller
    {
        private IConfiguration Configuration;

        public ProductController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public ActionResult Index()
        {
            ProductRepository ProductRepository = new ProductRepository();
            ModelState.Clear();
            return View(ProductRepository.GetAllProduct(this.Configuration.GetConnectionString("DefaultConnection")));
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product Product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ProductRepository ProductRepository = new ProductRepository();
                    if (ProductRepository.AddProduct(Product, this.Configuration.GetConnectionString("DefaultConnection")))
                    {
                        ViewBag.Message = "Product Added";
                    }

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        public ActionResult Edit(int Id)
        {
            ProductRepository productRepository = new ProductRepository();

            return View(productRepository.GetAllProduct(this.Configuration.GetConnectionString("DefaultConnection")).Find(Product => Product.ProductID == Id));
        }

        [HttpPost]
        public ActionResult Edit(int Id, Product obj)
        {
            try
            {
                ProductRepository productRepository = new ProductRepository();
                productRepository.UpdateProduct(obj, this.Configuration.GetConnectionString("DefaultConnection"));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }


        public ActionResult Delete(int Id)
        {
            try
            {
                ProductRepository productRepository = new ProductRepository();
                if (productRepository.DeleteProduct(Id, this.Configuration.GetConnectionString("DefaultConnection")))
                {
                    ViewBag.AlertMsg = "Product Deleted";
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
    }

}
