using System.Net;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorks;

namespace Controllers
{
    public class ProductController : ControllerBase {
        private readonly ILogger<ProductController> _logger;
        private IUnitOfWork _unitOfWork;
        public ProductController(ILogger<ProductController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("/api/products")]
        public async Task<ActionResult> GetProducts() {
            try
            {
                var products = await _unitOfWork.IProductRepository.FetchData();
                Console.WriteLine(products.Count);
                return Ok(products);
            }
            catch (System.Exception)
            {
                return Ok(HttpStatusCode.InternalServerError);
            }
        }
    }
}