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

        public IActionResult GetAllBook()
        {
            var getallbook = _bookRepositary.GetAllBook();
            return View(getallbook);
        }
        public IActionResult GetBook(int id)
        {
           var getBook=_bookRepositary.GetBook(id);
            return View(getBook);
        }
        //public List<BookModel> SearchBook(string tittle, string authorName)
        //{
        //    return _bookRepositary.SearchBook(tittle, authorName);
        //}
    }
}
