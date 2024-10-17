using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestCore8._0.Context;
using TestCore8._0.Dtos;

namespace TestCore8._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly dnzContext _dnzContext;

        public HomeController(dnzContext dnzContext)
        {
            _dnzContext = dnzContext;
        }

        public IActionResult Index()
        {
            FormattableString sql = $@"SELECT p.Id, p.Name, p.Price, c.Name categoryname from product p 
                                        inner join category c on c.Id = p.categoryid";
            var res = _dnzContext.Database.SqlQuery<productcatDto>(sql).ToList();

            return View(res);
        }

        public IActionResult Hakkinda()
        { 
            return View(); 
        }

        public IActionResult Iletisim()
        { 
            return View();
        }

        public IActionResult Urunlerimiz()
        {
            return View();
        }

    }
}
