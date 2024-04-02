using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutorentApi.Models;

namespace AutorentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private static readonly List<Category> categories = new List<Category>
        {
            new Category { id = 1, name="SportAutó", description="Sport" },
            new Category { id = 2, name="Kombi" ,description="Családi"},
            new Category { id = 3, name="Vegyes"  , description="Minden egyéb"},
            // Ide jöhetnek további termékek...
        };

        [HttpGet]
        public ActionResult<List<Category>> GetAll()
        {
            return categories;
        }

        // Itt adhatsz hozzá további API végpontokat, például a termék hozzáadásához, frissítéséhez vagy törléséhez.
    }
}
