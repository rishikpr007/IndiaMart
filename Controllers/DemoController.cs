using Microsoft.AspNetCore.Mvc;
using IndiaMart.Models;
using IndiaMart.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndiaMart.Controllers
{
    public class DemoController : Controller
    {
        private IConfiguration Configuration;
         
        public DemoController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public ActionResult Index(string sortOrder)
        {
            ViewBag.PriceSortParam = string.IsNullOrEmpty(sortOrder) ? "price_desc" : "" ;
            ProductRepository ProductRepository = new ProductRepository();
            ModelState.Clear();
            return View(ProductRepository.GetAllProduct(this.Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
