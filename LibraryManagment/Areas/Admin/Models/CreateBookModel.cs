using Autofac;
using LibraryManagement.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.Areas.Admin.Models
{
    public class CreateBookModel:BookBaseModel
    {
        [StringLength(60, MinimumLength =3)]
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }
        public DateTime PublicationDate { get; set; }
        public CreateBookModel(IBookService bookService)
            : base(bookService)
        {
        }
        public CreateBookModel()
            : base()
        {
        }
        public void Create()
        {
            var book = new Book
            {
                Title = this.Title,
                Author = this.Author,
                PublicationDate = DateTime.Now,
                Edition = this.Edition,
            };

            _bookService.CreateBook(book);
            //ResponseModel = new ResponseModel("Book creation successful.", ResponseType.Success);
        }
    }
}
