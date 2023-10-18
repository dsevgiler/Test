using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test.Context;

namespace Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly DnzContext _dnzContext;

        public HomeController(DnzContext dnzContext)
        {
            _dnzContext = dnzContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _dnzContext.Products.FromSqlRaw("select * from product");
            // result eklendi. 

            // result eklendi. 
            // daldkaslşkdşlsakd

            return Ok(result);
        }
    }
}
