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
            new Auto { Id = 1, Name = "Product 1", Price = 100 },
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
