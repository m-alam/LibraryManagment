using LibraryManagement.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Framework
{
    public class LibraryUnitOfWork:UnitOfWork,ILibraryUnitOfWork
    {
        public IBookRepository BookRepository { get; set; }
        public LibraryUnitOfWork(FrameworkContext context, IBookRepository bookRepository)
            : base(context)
        {

            BookRepository = bookRepository;
        }
    }
}
