namespace EasyBookShop.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Catagory { get; set; }
        public string TotalPages { get; set; }
        public string Language { get; set; }
    }
}
