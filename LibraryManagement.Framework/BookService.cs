using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Framework
{
    public class BookService:IBookService,IDisposable
    {
        private ILibraryUnitOfWork _libraryUnitOfWork;
        public BookService(ILibraryUnitOfWork libraryUnitOfWork)
        {
            _libraryUnitOfWork = libraryUnitOfWork;            
        }

        public void CreateBook(Book book)
        {
            var count = _libraryUnitOfWork.BookRepository.GetCount(x => x.Title == book.Title);
            if (count > 0)
                throw new DuplicationException("Book Already exist", nameof(book.Title));

            _libraryUnitOfWork.BookRepository.Add(book);
            _libraryUnitOfWork.Save();
        }
        public Book DeleteBook(int id)
        {
            var book = _libraryUnitOfWork.BookRepository.GetById(id);
            _libraryUnitOfWork.BookRepository.Remove(book);
            _libraryUnitOfWork.Save();
            return book;
        }

        public void Dispose()
        {
            //_libraryUnitOfWork?.Dispose();
        }

        public void EditBook(Book book)
        {
            var count = _libraryUnitOfWork.BookRepository.GetCount(x => x.Title == book.Title
                    && x.Id != book.Id);

            if (count > 0)
                throw new DuplicationException("Book title already exists", nameof(book.Title));

            var existingBook = _libraryUnitOfWork.BookRepository.GetById(book.Id);
            existingBook.Author = book.Author;
            existingBook.Edition = book.Edition;
            existingBook.PublicationDate = book.PublicationDate;
            existingBook.Title = book.Title;

            _libraryUnitOfWork.Save();
        }

        public Book GetBook(int id)
        {
            return _libraryUnitOfWork.BookRepository.GetById(id);
        }
                

        public (IList<Book> records, int total, int totalDisplay)
            GetBooks(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _libraryUnitOfWork.BookRepository.GetAll().ToList();
            
            return (result, 0,0);
        }
    }
}
