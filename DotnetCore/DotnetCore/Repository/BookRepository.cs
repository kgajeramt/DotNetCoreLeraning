using DotnetCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace DotnetCore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x=>x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x=>x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel()
                {
                    Id=1,Title="Mvc",Author="Kaushik"
                },
                new BookModel()
                {
                    Id=2,Title="C#",Author="Kaushik"
                },
                new BookModel()
                {
                    Id=3,Title="Dotnet",Author="Kaushik"
                },
                new BookModel()
                {
                    Id=4,Title="Java Script",Author="Kaushik"
                },
                new BookModel()
                {
                    Id=5,Title="Database",Author="Kaushik"
                }
            };
        }
    }
}
