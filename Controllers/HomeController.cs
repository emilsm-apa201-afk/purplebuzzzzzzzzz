using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using purplebuzzzzzzzz.Models;
using purplebuzzzzzzzz.ViewModels;
using static System.Net.Mime.MediaTypeNames;


namespace purplebuzzzzzzzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Slide> slides = new List<Slide>()
            {
                new Slide
                {
                    Id = 1,
                    Title = "Title 1",
                    Discount = 30,
                    Description ="Lorem ipsum dolar",
                    Order = 2,
                    Image = "1-1-524x617.png"
                },
                new Slide
                {
                    Id = 2,
                    Title = "Title 2",
                    Discount = 30,
                    Description ="Lorem ipsum dolar",
                    Order = 3,
                    Image = "1-1-524x617.png"
                },
                new Slide
                {
                    Id = 3,
                    Title = "Title 3",
                    Discount = 30,
                    Description ="Lorem ipsum dolar",
                    Order = 1,
                    Image = "1-1-524x617.png"
                }

                
            };

            List<Blog> blogs = new List<Blog>()
            {
                new Blog
                {
                    Id = 1,
                    Title = "title 1",
                    Description = "Lorem ipsum dolar",
                    Image = "1-1-310x220.jpg",
                    CreatedAt = DateTime.Now
                },
                new Blog
                {
                    Id = 2,
                    Title = "title 1",
                    Description = "Lorem ipsum dolar",
                    Image = "1-1-310x220.jpg",
                    CreatedAt = DateTime.Now
                },
                new Blog
                {
                    Id = 3,
                    Title = "title 1",
                    Description = "Lorem ipsum dolar",
                    Image = "1-1-310x220.jpg",
                    CreatedAt = DateTime.Now
                }
            };

            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Title = "title 1",
                    Price = 10,
                    Image ="1-10-270x300.jpg"
                },
                 new Product
                {
                    Id = 2,
                    Title = "title 2",
                    Price = 20,
                    Image ="1-7-270x300.jpg"
                },
                  new Product
                {
                    Id = 3,
                    Title = "title 3",
                    Price = 30,
                    Image ="1-5-270x300.jpg"
                },
                   new Product
                {
                    Id = 4,
                    Title = "title 4",
                    Price = 30,
                    Image ="1-4-270x300.jpg"
                },
                   new Product
                {
                    Id = 5,
                    Title = "title 5",
                    Price = 30,
                    Image ="1-2-270x300.jpg"
                },
                      new Product
                {
                    Id = 6,
                    Title = "title 6",
                    Price = 30,
                    Image ="1-9-270x300.jpg"
                },
                         new Product
                {
                    Id = 7,
                    Title = "title 7",
                    Price = 30,
                    Image ="1-1-270x300.jpg"
                },
                            new Product
                {
                    Id = 8,
                    Title = "title 8",
                    Price = 30,
                    Image ="1-3-270x300.jpg"
                }
            };

            HomeVM vm = new HomeVM()
            {
                Slides = slides,
                Blogs = blogs,
                Products = products,
            };
            return View(vm);
        }

      
    }
}
