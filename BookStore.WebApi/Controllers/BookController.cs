using BookStore.Core;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookServices _boolServices;
    public BookController(IBookServices bookServices) {
        _boolServices = bookServices;
     }
    [HttpGet]
    public IActionResult GetBooks()
    {
        return Ok(_boolServices.GetBooks());
    }
}
