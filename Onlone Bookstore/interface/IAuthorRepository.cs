using static Onlone_Bookstore.Database.Entities.book;

public interface IAuthorRepository
{
    Task<List<Book>> GetBooks();
    Task<Book> GetBookById(int bookId);
    Task CreateBook(Book book);
    Task UpdateBook(int bookId, Book book);
    Task DeleteBook(int bookId);
}