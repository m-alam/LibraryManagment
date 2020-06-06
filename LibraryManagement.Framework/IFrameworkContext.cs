using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Framework
{
    public interface IFrameworkContext
    {
        DbSet<Book> Books { get; set; }

    }
}
