using LibraryManagement.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Framework
{
    public interface IBookRepository:IRepository<Book, int, FrameworkContext>
    {
        IList<Book> GetLatestBooks();
    }
}
