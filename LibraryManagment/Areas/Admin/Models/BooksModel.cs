using Autofac;
using LibraryManagement.Framework;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.Areas.Admin.Models
{
    public class BooksModel : BookBaseModel
    {
        public BooksModel(IBookService bookService)
            :base(bookService)
        {
        }
        public BooksModel()
            :base()
        {            
        }
        internal object GetBooks(DataTableAjaxRequestModels tableModel)
        {           

            var data = _bookService.GetBooks
                (
                    tableModel.PageIndex,
                    tableModel.PageSize,
                    tableModel.SearchText,
                    tableModel.GetSortText(new string[] { "Title", "Author", "Edition", "PublicationDate" })
                );
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[] {
                    
                    record.Title,
                    record.Author,
                    record.Edition,
                    record.PublicationDate.ToString(),
                    
                    }
                ).ToArray()
            };
        }
        internal string Delete(int id)
        {
            var deletedBook = _bookService.DeleteBook(id);
            return deletedBook.Title;
        }
    }
}
