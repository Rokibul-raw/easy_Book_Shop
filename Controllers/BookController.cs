using EasyBookShop.Models;
using EasyBookShop.Repositary;
using Microsoft.AspNetCore.Mvc;

namespace EasyBookShop.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepositary _bookRepositary = null;

        public BookController()
        {
            _bookRepositary = new BookRepositary();
        }
            
         public List<BookModel> GetAllBook()
            {
              return _bookRepositary.GetAllBook();
            }
        public BookModel GetById(int id)
        {
            return _bookRepositary.GetById(id);
        }
        public List<BookModel> SearchBook(string tittle, string authorName)
        {
            return _bookRepositary.SearchBook(tittle, authorName);
        }
    }
}
