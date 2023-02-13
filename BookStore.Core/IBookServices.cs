using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Core
{
    public interface IBookServices
    {
        List<Book> GetBooks();
    }
}