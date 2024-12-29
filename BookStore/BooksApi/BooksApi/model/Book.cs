using System;
using System.ComponentModel.DataAnnotations;

namespace BooksApi.model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        // Mark properties as required using C# 11 'required' keyword
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string ISBN { get; set; }

        public DateTime PublicationDate { get; set; }

        // Default constructor for EF Core
        public Book() { }

        // Constructor for manual creation
        public Book(string title, string author, string isbn)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Author = author ?? throw new ArgumentNullException(nameof(author));
            ISBN = isbn ?? throw new ArgumentNullException(nameof(isbn));
        }
    }
}
