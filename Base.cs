using ConsoleApp19;
using System;
using System.Collections.Generic;

namespace ConsoleApp19
{
    internal abstract class Base
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    class Book : Base
    {
        private static int _id = 0;

        public string Author { get; set; }
        public Category Category { get; set; }

        public Book(string name, string author, Category category)
        {
            _id++;
            Name = name;
            Author = author;
            Category = category;
        }

        public override string ToString()
        {
            return "Name:" + Name + ", Author:" + Author + ", Category:" + Category.Name;
        }
    }

    class Category : Base
    {
        public Category(string name)
        {
            Id = 0;
            Name = name;
        }
    }

    class BookLibrary : Base
    {
        private List<Book> _books;

        public BookLibrary()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void ListAllBooks()
        {
            Console.WriteLine("Library Name: " + Name);
            foreach (var book in _books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
