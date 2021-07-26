using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace IndiaMart.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class DisplaySellerProductVM
    {
        public int SellProId { get; set; }
        public int SellerID { get; set; }
        [Display(Name = "Seller Name")]
        public string SellerName { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }
        public decimal Price { get; set; }

    }

    public class GetProductVM
    {
        public int ProductID { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
    }

    public class Product
    {
        [Display(Name = "Product ID")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Brand Name is required.")]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
    }

    public class Seller
    {
        [Display(Name = "Seller ID")]
        public int SellerID { get; set; }

        [Required(ErrorMessage = "Seller name is required.")]
        [Display(Name = "Seller Name")]
        public string SellerName { get; set; }

        [Required(ErrorMessage = "Owner Name is required.")]
        public string OwnerName { get; set; }
    }

    public class SellPro
    {
        public int SellProID { get; set; }

        public int SellerID { get; set; }

        public int ProductID { get; set; }

        public virtual Product Product { get; set; }

        public virtual Seller Seller { get; set; }


    }

}
