using System;
using System.Collections.Generic;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>();
            List<Book> newBooks = new List<Book>();
            BookLibrary myLibrary = new BookLibrary();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("   ________________  \r\n ((                ))\r\n  ))Murads Library(( \r\n ((                ))\r\n   ----------------  ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1 Create New Library ");
                Console.WriteLine("2 Create New Category");
                Console.WriteLine("3 Create New Book    ");
                Console.WriteLine("4 Enter The Library  ");
                Console.WriteLine("5 Exit               ");
                Console.ResetColor();

                Console.WriteLine("");
                string choice = Console.ReadLine();
                Console.WriteLine("");

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the name of your Library:");
                        string libraryName = Console.ReadLine();

                       
                        myLibrary = new BookLibrary { Name = libraryName };
                        Console.WriteLine("Library '" + libraryName + "' has been created.");
                        break;

                    case "2":
                        Console.WriteLine("Enter the name of your Category:");
                        string categoryName = Console.ReadLine();

                        
                        Category newCategory = new Category(categoryName);

                       
                        categories.Add(newCategory);
                        Console.WriteLine("Category '" + categoryName + "' has been created.");
                        break;

                    case "3":
                        Console.WriteLine("Enter book details:");
                        Console.WriteLine("Book Name:");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("Author:");
                        string authorName = Console.ReadLine();

                        
                        Console.WriteLine("Choose a category for the book:");

                        for (int i = 0; i < categories.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + categories[i].Name);
                        }

                        if (int.TryParse(Console.ReadLine(), out int categoryChoice) && categoryChoice >= 1 && categoryChoice <= categories.Count)
                        {
                            Category selectedCategory = categories[categoryChoice - 1];

                           
                            Book newBook = new Book(bookName, authorName, selectedCategory);

                           
                            newBooks.Add(newBook);

                            Console.WriteLine("Book has been created.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid category choice.");
                        }
                        break;

                    case "4":
    if (myLibrary != null)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1 Add Book");
            Console.WriteLine("2 Show Books");
            Console.WriteLine("3 Leave");
            Console.ResetColor();

            string libraryChoice = Console.ReadLine();

            switch (libraryChoice)
            {
                case "1":
                   
                    Console.WriteLine("Select a book to add:");
                    for (int i = 0; i < newBooks.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + newBooks[i].ToString());
                    }

                    if (int.TryParse(Console.ReadLine(), out int bookChoice) && bookChoice >= 1 && bookChoice <= newBooks.Count)
                    {
                        
                        myLibrary.AddBook(newBooks[bookChoice - 1]);
                        Console.WriteLine("Book has been added to the library.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid book choice.");
                    }
                    break;

                case "2":
                    
                    myLibrary.ListAllBooks();
                    break;

                case "3":
                    
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("No library created yet. Please create a library first.");
    }
    break;

                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
