using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutorentApi.Models;
    
    namespace AutorentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private static readonly List<Sales> sales = new List<Sales>
        {
            new Sales { id = 1, userId=1, autoId="1", description="Sport", percent=5  },
            new Sales { id = 2,userId=2, autoId="2", description="Kombi", percent=10  },
            new Sales { id = 3,userId=3, autoId="3", description="Vegyes", percent=15 },
            // Ide jöhetnek további termékek...
        };

        [HttpGet]
        public ActionResult<List<Sales>> GetAll()
        {
            return sales;
        }

        // Itt adhatsz hozzá további API végpontokat, például a termék hozzáadásához, frissítéséhez vagy törléséhez.

    }
}
