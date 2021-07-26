using IndiaMart.Models;
using IndiaMart.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndiaMart.Controllers
{
    public class SellerController : Controller
    {
        private IConfiguration Configuration;
 
        public SellerController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public ActionResult Index()
        {
            SellerRepository sellerRepository = new SellerRepository();
            ModelState.Clear();
            return View(sellerRepository.GetAllSeller(this.Configuration.GetConnectionString("DefaultConnection")));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Seller seller)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    SellerRepository sellerRepository = new SellerRepository();
                    if (sellerRepository.AddSeller(seller, this.Configuration.GetConnectionString("DefaultConnection")))
                    {
                        ViewBag.Message = "Seller Added";
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
            SellerRepository sellerRepository = new SellerRepository();

            return View(sellerRepository.GetAllSeller(this.Configuration.GetConnectionString("DefaultConnection")).Find(Seller => Seller.SellerID == Id));
        }

        [HttpPost]
        public ActionResult Edit(int Id, Seller obj)
        {
            try
            {
                SellerRepository sellerRepository = new SellerRepository();
                sellerRepository.UpdateSeller(obj, this.Configuration.GetConnectionString("DefaultConnection"));
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
                SellerRepository sellerRepository = new SellerRepository();
                if (sellerRepository.DeleteSeller(Id, this.Configuration.GetConnectionString("DefaultConnection")))
                {
                    ViewBag.AlertMsg = "Seller Deleted";
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        public ActionResult Details(int id)
        {
            SellProRepository sellproRepository = new SellProRepository();
            //Session["SellerId"] = id;
            HttpContext.Session.SetInt32("SellerId", id);

            return View(sellproRepository.DisplaySellerProduct(id, this.Configuration.GetConnectionString("DefaultConnection")));
        }

        public ActionResult AddSellPro()
        {
            SellerRepository sellerRepository = new SellerRepository();
            ProductRepository productRepository = new ProductRepository();

            ViewBag.SellerList = sellerRepository.GetAllSeller(this.Configuration.GetConnectionString("DefaultConnection")).Select(i => new { i.SellerID, i.SellerName });
            var productList = productRepository.GetAllProductList(this.Configuration.GetConnectionString("DefaultConnection"));
            List<SelectListItem> lstProduct = new List<SelectListItem>();

            foreach (var item in productList)
            {
                lstProduct.Add(new SelectListItem
                {
                    Text = item.ProductName,
                    Value = item.ProductID.ToString()
                });
            }
            ViewBag.ProductList = lstProduct;


            return View();
        }

        [HttpPost]
        public ActionResult AddSellPro(SellPro detail)
        {
            try
            {
                detail.SellerID = (int)HttpContext.Session.GetInt32("SellerId");
                if (ModelState.IsValid)
                {
                    SellProRepository sellProRepository = new SellProRepository();
                    var check = sellProRepository.DisplaySellerProduct(detail.SellerID, this.Configuration.GetConnectionString("DefaultConnection"));
                    // var detailCount = check.Where(i => i.SellerID == detail.SellerID && i.ProductId == detail.ProductID).Count();



                    if (sellProRepository.AddSellPro(detail, this.Configuration.GetConnectionString("DefaultConnection")))
                    {
                        ViewBag.Message = "Product Added";
                    }
                }
                return RedirectToAction("Details", new { id = detail.SellerID });
            }
            catch
            {
                return View();
            }

        }

        public ActionResult DeleteProductFromSeller(int id, int sellerId)
        {
            try
            {
                SellProRepository sellerRepository = new SellProRepository();
                if (sellerRepository.DeleteProductFromSeller(id, this.Configuration.GetConnectionString("DefaultConnection")))
                {
                    ViewBag.AlertMsg = "Product Deleted";
                }

                return RedirectToAction("Details", new { id = sellerId });
            }
            catch
            {
                return View();
            }

        }


    }

}
