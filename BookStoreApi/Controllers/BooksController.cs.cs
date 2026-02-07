using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/books")]
public class BooksController : ControllerBase
{
    private readonly BookService _service;

    public BooksController(BookService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll([FromQuery] string? title, [FromQuery] string? author)
    {
        var books = _service.GetAll(title, author);
        return Ok(books);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var book = _service.GetById(id);
        if (book == null) return NotFound();

        return Ok(book);
    }

    [HttpPost]
    public IActionResult Create(CreateBookDto dto)
    {
        var result = _service.Create(dto);

        if (!result.Success)
            return Conflict(result.Error);

        return CreatedAtAction(nameof(GetById), new { id = result.Book.Id }, result.Book);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, UpdateBookDto dto)
    {
        var result = _service.Update(id, dto);

        if (!result.Success)
            return BadRequest(result.Error);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var deleted = _service.Delete(id);
        if (!deleted) return NotFound();

        return NoContent();
    }
}