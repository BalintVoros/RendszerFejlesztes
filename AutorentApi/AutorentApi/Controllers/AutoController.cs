using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutorentApi.Models;

namespace AutorentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        private static readonly List<Auto> products = new List<Auto>
        {
            new Auto { Id = 1, Name = "Audi a3", Price = 100, Brand = "Audi", Model = "a3", DailyPrice = 30},
            new Auto { Id = 2, Name = "BMW e320", Price = 200 , Brand = "BMW", Model = "e320", DailyPrice = 50},
            new Auto { Id = 3, Name = "Mercedes c320", Price = 300 , Brand = "Mercedes", Model = "c320", DailyPrice = 100}
            // Ide jöhetnek további termékek...
        };

        [HttpGet]
        public ActionResult<List<Auto>> GetAll()
        {
            return products;
        }



        // Itt adhatsz hozzá további API végpontokat, például a termék hozzáadásához, frissítéséhez vagy törléséhez.
    }
}
