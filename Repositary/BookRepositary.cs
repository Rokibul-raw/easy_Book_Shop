using EasyBookShop.Models;

namespace EasyBookShop.Repositary
{
    public class BookRepositary
    {
        public List<BookModel> GetAllBook()
        {
            return DataSource();
        }
        public BookModel GetBook(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        //    public List<BookModel>SearchBook(string tittle,string authorName)
        //    {
        //        return DataSource().Where(x => x.Title.Contains(tittle) || x.Author.Contains(authorName)).ToList();
        //    }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
                {
                    new BookModel() { Id = 1, Title = "C#", Author = "Bulbul" ,Description="This is best ook for C# programer",Catagory="Action",TotalPages="200",Language="English" },
                    new BookModel() { Id = 2, Title = "C", Author = "Babul", Description="This is best ook for C# programer",Catagory="Action",TotalPages="200",Language="English" },
                    new BookModel() { Id = 3, Title = "C++", Author = "Thomson" ,Description="This is best ook for C# programer",Catagory="Action",TotalPages="200",Language="English" },
                    new BookModel() { Id = 4, Title = "Java", Author = "Alexjender" ,Description="This is best ook for C# programer",Catagory="Action",TotalPages="200",Language="English"},
                    new BookModel() { Id = 5, Title = "Python", Author = "Stib Jobs",Description="This is best ook for C# programer",Catagory="Action",TotalPages="200",Language="English" },
                    new BookModel() { Id = 6, Title = "Javascript", Author = "Mark Jukerbarg",Description="This is best ook for C# programer",Catagory="Action",TotalPages="200",Language="English" }

                };
        }
    }
}
