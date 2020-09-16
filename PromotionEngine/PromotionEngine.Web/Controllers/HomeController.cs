namespace PromotionEngine.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using PromotionEngine.Web.Models;
    using PromotionEngine.DomainServices.ProductService;
    using PromotionEngine.Web.ViewModels;

    /// <summary>
    /// Provides functionality to display products.
    /// </summary>
    public class HomeController : Controller
    {
        #region Member Variables

        private readonly ILogger<HomeController> logger;
        private readonly IProductService productService;

        #endregion Member Variables

        public HomeController(ILogger<HomeController> logger,
                              IProductService productService)
        {
            this.logger = logger;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            IndexViewModel indexViewModel = new IndexViewModel();

            indexViewModel.Products = productService.GetProducts();

            return View(indexViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
