using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    public class ProductController : Controller {
        private readonly ILogger<ProductController> _logger;
        private readonly IConfiguration _configuration;
        private readonly string _urlHost;

        public ProductController(ILogger<ProductController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _urlHost = _configuration["UrlHost"] ?? "http://localhost:8080";
        }
    }
}