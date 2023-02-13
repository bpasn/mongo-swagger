namespace BookStore.Core;
public class BookServices : IBookServices
{
    public List<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book
            {
                Name = "Test",
                Price = 1.11
            }
        };
    }
}
