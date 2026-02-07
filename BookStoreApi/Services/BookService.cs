public class BookService
{
    private readonly List<Book> _books = new();

    private readonly string[] ValidGenres =
        { "ficção", "romance", "mistério", "terror", "fantasia", "aventura" };

    public IEnumerable<Book> GetAll(string? title, string? author)
    {
        var query = _books.AsQueryable();

        if (!string.IsNullOrWhiteSpace(title))
            query = query.Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrWhiteSpace(author))
            query = query.Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase));

        return query.ToList();
    }

    public Book? GetById(Guid id) => _books.FirstOrDefault(b => b.Id == id);

    public (bool Success, string Error, Book? Book) Create(CreateBookDto dto)
    {
        if (_books.Any(b => b.Title == dto.Title && b.Author == dto.Author))
            return (false, "Livro já existe", null);

        if (!ValidGenres.Contains(dto.Genre.ToLower()))
            return (false, "Gênero inválido", null);

        if (dto.Price < 0 || dto.Stock < 0)
            return (false, "Preço ou estoque inválido", null);

        var book = new Book
        {
            Title = dto.Title,
            Author = dto.Author,
            Genre = dto.Genre,
            Price = dto.Price,
            Stock = dto.Stock
        };

        _books.Add(book);
        return (true, "", book);
    }

    public (bool Success, string Error) Update(Guid id, UpdateBookDto dto)
    {
        var book = GetById(id);
        if (book == null)
            return (false, "Livro não encontrado");

        if (_books.Any(b => b.Id != id && b.Title == dto.Title && b.Author == dto.Author))
            return (false, "Livro duplicado");

        if (!ValidGenres.Contains(dto.Genre.ToLower()))
            return (false, "Gênero inválido");

        if (dto.Price < 0 || dto.Stock < 0)
            return (false, "Preço ou estoque inválido");

        book.Title = dto.Title;
        book.Author = dto.Author;
        book.Genre = dto.Genre;
        book.Price = dto.Price;
        book.Stock = dto.Stock;
        book.UpdatedAt = DateTime.UtcNow;

        return (true, "");
    }

    public bool Delete(Guid id)
    {
        var book = GetById(id);
        if (book == null) return false;

        _books.Remove(book);
        return true;
    }
}
