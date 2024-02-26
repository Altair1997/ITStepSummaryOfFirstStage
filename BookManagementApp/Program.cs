using System;
using System.Collections.Generic;

namespace BookManagerApp
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }

    public class BookManager
    {
        private List<Book> books;

        public BookManager()
        {
            books = new List<Book>();
        }

        public void AddNewBook(string name, string author, int year)
        {
            Book newBook = new Book
            {
                Name = name,
                Author = author,
                Year = year
            };

            books.Add(newBook);
            Console.WriteLine("New book added successfully!");
        }

        public void ShowAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
            }
            else
            {
                Console.WriteLine("List of Books:");
                foreach (var book in books)
                {
                    Console.WriteLine($"Name: {book.Name}, Author: {book.Author}, Year: {book.Year}");
                }
            }
        }

        public void SearchBooksByName(string name)
        {
            bool found = false;
            foreach (var book in books)
            {
                if (book.Name.ToLower().Contains(name.ToLower()))
                {
                    Console.WriteLine($"Name: {book.Name}, Author: {book.Author}, Year: {book.Year}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Book not found.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager();

            while (true)
            {
                Console.WriteLine("__________________________________________________");
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add New Book");
                Console.WriteLine("2. Show All Books");
                Console.WriteLine("3. Search Books by Name");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter book name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter author name: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter publication year: ");
                        int year;
                        if (!int.TryParse(Console.ReadLine(), out year))
                        {
                            Console.WriteLine("Invalid year. Please enter a number.");
                            continue;
                        }
                        bookManager.AddNewBook(name, author, year);
                        break;
                    case 2:
                        bookManager.ShowAllBooks();
                        break;
                    case 3:
                        Console.Write("Enter book name to search: ");
                        string searchName = Console.ReadLine();
                        bookManager.SearchBooksByName(searchName);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid option.");
                        break;
                }
            }
        }
    }
}
