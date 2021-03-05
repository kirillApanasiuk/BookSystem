
using Microsoft.AspNetCore.Mvc;

namespace BookSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
       [HttpGet]
       public IActionResult GetAllBooks()
        {
            return Ok(new { Message = "Hello", Value = 123 });
        }
    }
}
