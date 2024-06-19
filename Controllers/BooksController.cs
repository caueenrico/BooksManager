using BooksManager.Comunication.Request;
using Microsoft.AspNetCore.Mvc;

namespace BooksManager.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    //criando um livro
    [HttpPost]
    [ProducesResponseType(typeof(RequestRedisterBook), StatusCodes.Status201Created)]
    public IActionResult CreateBook([FromBody] RequestRedisterBook request)
    {
        var response = new RequestRedisterBook
        {
            Id = request.Id,
            Title = request.Title,
            author = request.author,
            kind = request.kind,
            price = request.price,
            stock = request.stock,
        };

        return Created(string.Empty, response);
    }
    //buscando todos os livros
    [HttpGet("all-books")]
    [ProducesResponseType(typeof(List<Books>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult AllBooks()
    {
        var allbooks = new List<Books>
        {
            new Books {Id = 1,
            Title = "Star Wars",
            author = "CAue Enrico",
            kind = "aventura",
            price = 120,
            stock = 10},

            new Books {Id = 2,
            Title = "sei la",
            author = "CAue Enrico",
            kind = "ficção",
            price = 120,
            stock = 8},

            new Books {Id = 3,
            Title = "bible",
            author = "God",
            kind = "real",
            price = 10020,
            stock = 8}
        };
        return Ok(allbooks);
    }
    //editando um livro
    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult EditBook([FromRoute] int id)
    {
        return Ok("atualizado " + id);
    }

    //deletando um livro
    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }

}