using LibraryManagement.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Framework
{
    public interface ILibraryUnitOfWork : IUnitOfWork 
    {
        IBookRepository BookRepository { get; set; }
    }
}
