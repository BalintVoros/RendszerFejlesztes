using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutorentApi.Models;

namespace AutorentApi.Controllers
    
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static readonly List<User> users = new List<User>
        {
            new User { id = 1, name="Kiss József", userName="Admin", password="Barack"}
            , new User { id = 2, name="Nagy Béla", userName="Bela", password="Körte"}
            , new User { id = 3, name="Kovács László", userName="Root", password="Alma"}
        };
        [HttpGet]
        public ActionResult<List<User>> GetAll()
        {
            return users;
        }
    }
}
