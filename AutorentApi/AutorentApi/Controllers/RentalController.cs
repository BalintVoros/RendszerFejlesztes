using AutorentApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutorentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private static readonly List<Rental> rentals = new List<Rental>
        {
            new Rental { id = 1, userId=1, autoId="1" , fromDate="2023.09.04", toDate="2024.05.09",created="2023.09.03" },
            new Rental { id = 2,userId=2, autoId="2" , fromDate="2023.07.04", toDate="2024.02.09",created="2023.09.03" },
            new Rental { id = 3,userId=3, autoId="3" , fromDate="2023.08.04", toDate="2024.03.09",created="2023.09.03" },
            // Ide jöhetnek további termékek...
        };

        [HttpGet]
        public ActionResult<List<Rental>> GetAll()
        {
            return rentals;
        }

        // Itt adhatsz hozzá további API végpontokat, például a termék hozzáadásához, frissítéséhez vagy törléséhez.
    }
}