using EasyBookShop.Models;

namespace EasyBookShop.Repositary
{
    public class BookRepositary
    {
        public List<BookModel> GetAllBook()
        {
            return DataSource();
        }
        public BookModel GetById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel>SearchBook(string tittle,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(tittle) || x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "C#", Author = "Bulbul" },
                new BookModel() { Id = 1, Title = "C", Author = "Babul" },
                new BookModel() { Id = 1, Title = "C++", Author = "Bulbuli" }

            };
        }
    }
}
