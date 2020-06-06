using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LibraryManagement.Data;

namespace LibraryManagement.Framework
{
    public class BookRepository:Repository<Book, int, FrameworkContext>,IBookRepository
    {
        public BookRepository(FrameworkContext dbContext)
            : base(dbContext)
        {

        }
        public IList<Book> GetLatestBooks()
        {

            return Get(x => x.PublicationDate < DateTime.Now.AddDays(-7)).ToList();
        }
    }
}
