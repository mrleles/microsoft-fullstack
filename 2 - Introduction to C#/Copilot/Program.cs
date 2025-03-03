using System;

class LibraryManagementSystem
{
    static string[] books = new string[5];
    static int bookCount = 0;

    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("1. Add a new book");
            Console.WriteLine("2. Remove a book");
            Console.WriteLine("3. Display available books");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    RemoveBook();
                    break;
                case 3:
                    DisplayBooks();
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 4);
    }

    static void AddBook()
    {
        if (bookCount < 5)
        {
            Console.Write("Enter the title of the book: ");
            string title = Console.ReadLine();
            books[bookCount] = title;
            bookCount++;
            Console.WriteLine("Book added successfully.");
        }
        else
        {
            Console.WriteLine("Library is full. Cannot add more books.");
        }
    }

    static void RemoveBook()
    {
        Console.Write("Enter the title of the book to remove: ");
        string title = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < bookCount; i++)
        {
            if (books[i].Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                books[i] = books[bookCount - 1];
                books[bookCount - 1] = null;
                bookCount--;
                found = true;
                Console.WriteLine("Book removed successfully.");
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Book not found.");
        }
    }

    static void DisplayBooks()
    {
        if (bookCount == 0)
        {
            Console.WriteLine("No books available.");
        }
        else
        {
            Console.WriteLine("Available books:");
            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
        }
    }
}