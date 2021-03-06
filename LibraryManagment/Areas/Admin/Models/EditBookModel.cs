﻿using LibraryManagement.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagment.Areas.Admin.Models
{
    public class EditBookModel:BookBaseModel
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }

        public EditBookModel(IBookService bookService) : base(bookService) { }
        public EditBookModel() : base() { }

        public void Edit()
        {
            var book = new Book
            {
                Id = this.Id,
                Title = this.Title,
                Author = this.Author,
                Edition = this.Edition,
                PublicationDate = DateTime.Now
            };

            _bookService.EditBook(book);
        }

        internal void Load(int id)
        {
            var book = _bookService.GetBook(id);
            if (book != null)
            {
                Id = book.Id;
                Title = book.Title;
                Author = book.Author;
                Edition = book.Edition;
            }
        }
    }
}
