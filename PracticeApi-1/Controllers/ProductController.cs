using PracticeApi_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticeApi_1.Controllers
{
    public class ProductController : ApiController
    {

        Product[] products = new Product[]
        {
            new Product  { Id = 1, Name = "Airdopes 131", Category = "Earpods", Price = 999, Image = "adn-static1.nykaa.com/nykdesignstudio-images/pub/media/catalog/product/n/y/tr:w-270,/nyfboat000132_1_8644351a.jpg?rnd=20200526195200"},
            new Product  { Id = 2, Name = "GigaByte", Category = "Mouse", Price = 659, Image = "images-cdn.ubuy.co.in/633ff1a365a4c6479841033c-gigabyte-gm-m5050-optical-wired-mouse.jpg"},
            new Product { Id = 3, Name = "Nord CE 2 Lite", Category = "SmartPhone", Price = 19500, Image = "static.gadgetandgear.com/tmp/product/20220516_1652693777_131697.png"},
            new Product { Id = 4, Name = "Circle101", Category = "HeadPhones", Price = 849, Image = "www.tmtechnology.in/wp-content/uploads/2020/09/circle2.jpg"},
            new Product { Id = 5, Name = "Intel Core I5", Category = "CPU", Price = 35000, Image = "encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSJH8zXiDarxuVg90-VNSZWOAecGRKNADEJrg&usqp=CAU"}
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }


        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            return Ok(product);
        }

    }
}
