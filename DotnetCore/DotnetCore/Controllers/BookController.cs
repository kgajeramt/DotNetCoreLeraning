using DotnetCore.Models;
using DotnetCore.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DotnetCore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository= new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View();
        }
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string bookname,string authorname)
        {
            return _bookRepository.SearchBook(bookname, authorname);
        }
    }
}
