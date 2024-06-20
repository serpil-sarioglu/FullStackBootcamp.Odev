using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndArrays
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        private double _price;
        public double Price
        {
            get => _price;
            set => _price = value + (value * 0.20);
        }

        public Book(int id, string title, string author, double price)
        {
            ID = id;
            Title = title;
            Author = author;
            Price = price;
        }

    }
    public class BookRepository : IBookRepository
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public void Add(Book book)
        {
            Books.Add(book);
        }

        public List<Book> GetBooks()
        {
            return Books;
        }
    }
    public interface IBookRepository
    {
        void Add(Book book);
        List<Book> GetBooks();


    }
    public class BookService(IBookRepository bookRepository)
    {
        public void Add(Book book)
        {
            bookRepository.Add(book);
        }
        public List<Book> GetBooks()
        {
            return bookRepository.GetBooks();
        }
    }
}
