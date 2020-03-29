using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MyClassLibaray.Entity;
namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        IConfiguration configuration;
        public ProductController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public ActionResult GetAllProducts()
        {
            try
            {
                ServiceRepository serviceObj = new ServiceRepository(configuration);
                HttpResponseMessage response = serviceObj.GetResponse("api/Product/getallproducts");
                response.EnsureSuccessStatusCode();
                List<Product> products = response.Content.ReadAsAsync<List<Product>>().Result;
                ViewBag.Title = "All Products";
                return View(products);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}