using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WcfServiceHost
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Genre { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public DateTime PublishDate { get; set; }
        [DataMember]
        public string Description { get; set; }
    }

    public class BooksService : IBooksService
    {
        List<Book> _books;

        public BooksService()
        {
            var booksXml = XDocument.Load("books.xml");
            _books = booksXml.Root
                .Elements("book")
                .Select(e => new Book
                {
                    Id = e.Attribute("id").Value,
                    Author = e.Element("author").Value,
                    Title = e.Element("title").Value,
                    Genre = e.Element("genre").Value,
                    Description = e.Element("description").Value,
                    Price = Decimal.Parse(e.Element("price").Value),
                    PublishDate = DateTime.Parse(e.Element("publish_date").Value),
                })
                .ToList();
        }

        public Book GetBookById(string id)
        {
            return _books.Where(b => b.Id == id).FirstOrDefault();
        }

        public IEnumerable<string> GetGenres()
        {
            return _books.Select(b => b.Genre).Distinct();
        }

        public IEnumerable<Book> GetBooksByGenre(string genre)
        {
            return _books.Where(b => b.Genre == genre);
        }

    }
}
