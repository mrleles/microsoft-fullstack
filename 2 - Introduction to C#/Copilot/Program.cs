using System;
using System.Collections.Generic;

class LibraryManager
{
    // List to store the books
    static List<string> books = new List<string>();
    // Dictionary to track borrowed books by user
    static Dictionary<string, List<string>> borrowedBooks = new Dictionary<string, List<string>>();
    // List to track checked-out books
    static List<string> checkedOutBooks = new List<string>();

    static void Main()
    {
        // Infinite loop to keep the program running until the user decides to exit
        while (true)
        {
            Console.WriteLine("Would you like to add, remove, search, borrow, return, check in a book or exit? (add/remove/search/borrow/return/checkin/exit)");
            string action = Console.ReadLine().ToLower(); // Convert input to lowercase

            if (action == "add")
            {
                AddBook(); // Call AddBook method if user wants to add a book
            }
            else if (action == "remove")
            {
                RemoveBook(); // Call RemoveBook method if user wants to remove a book
            }
            else if (action == "search")
            {
                SearchBook(); // Call SearchBook method if user wants to search for a book
            }
            else if (action == "borrow")
            {
                BorrowBook(); // Call BorrowBook method if user wants to borrow a book
            }
            else if (action == "return")
            {
                ReturnBook(); // Call ReturnBook method if user wants to return a book
            }
            else if (action == "checkin")
            {
                CheckInBook(); // Call CheckInBook method if user wants to check in a book
            }
            else if (action == "exit")
            {
                break; // Exit the loop if user wants to exit
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', 'search', 'borrow', 'return', 'checkin', or 'exit'.");
            }

            DisplayBooks(); // Display the list of books after each action
        }
    }

    // Method to add a book to the list
    static void AddBook()
    {
        Console.WriteLine("Enter the title of the book to add:");
        string newBook = Console.ReadLine();

        if (books.Count < 5)
        {
            books.Add(newBook); // Add the book if the list has less than 5 books
        }
        else
        {
            Console.WriteLine("The library is full. No more books can be added.");
        }
    }

    // Method to remove a book from the list
    static void RemoveBook()
    {
        Console.WriteLine("Enter the title of the book to remove:");
        string removeBook = Console.ReadLine();

        if (books.Remove(removeBook))
        {
            Console.WriteLine("Book removed."); // Confirm removal if the book was found and removed
        }
        else
        {
            Console.WriteLine("Book not found."); // Inform the user if the book was not found
        }
    }

    // Method to search for a book in the list
    static void SearchBook()
    {
        Console.WriteLine("Enter the title of the book to search:");
        string searchBook = Console.ReadLine();

        if (books.Contains(searchBook))
        {
            Console.WriteLine("The book is available."); // Inform the user if the book is found
        }
        else
        {
            Console.WriteLine("The book is not in the collection."); // Inform the user if the book is not found
        }
    }

    // Method to borrow a book
    static void BorrowBook()
    {
        Console.WriteLine("Enter your name:");
        string userName = Console.ReadLine();

        if (!borrowedBooks.ContainsKey(userName))
        {
            borrowedBooks[userName] = new List<string>();
        }

        if (borrowedBooks[userName].Count >= 3)
        {
            Console.WriteLine("You have already borrowed 3 books. Return a book before borrowing a new one.");
            return;
        }

        Console.WriteLine("Enter the title of the book to borrow:");
        string borrowBook = Console.ReadLine();

        if (books.Contains(borrowBook))
        {
            borrowedBooks[userName].Add(borrowBook);
            books.Remove(borrowBook);
            checkedOutBooks.Add(borrowBook);
            Console.WriteLine("Book borrowed.");
        }
        else
        {
            Console.WriteLine("Book not available.");
        }
    }

    // Method to return a book
    static void ReturnBook()
    {
        Console.WriteLine("Enter your name:");
        string userName = Console.ReadLine();

        if (!borrowedBooks.ContainsKey(userName) || borrowedBooks[userName].Count == 0)
        {
            Console.WriteLine("You have no borrowed books.");
            return;
        }

        Console.WriteLine("Enter the title of the book to return:");
        string returnBook = Console.ReadLine();

        if (borrowedBooks[userName].Remove(returnBook))
        {
            books.Add(returnBook);
            checkedOutBooks.Remove(returnBook);
            Console.WriteLine("Book returned.");
        }
        else
        {
            Console.WriteLine("You did not borrow this book.");
        }
    }

    // Method to check in a book
    static void CheckInBook()
    {
        Console.WriteLine("Enter the title of the book to check in:");
        string checkInBook = Console.ReadLine();

        if (checkedOutBooks.Contains(checkInBook))
        {
            checkedOutBooks.Remove(checkInBook);
            Console.WriteLine("Book checked in.");
        }
        else
        {
            Console.WriteLine("This book is not checked out.");
        }
    }

    // Method to display the list of books
    static void DisplayBooks()
    {
        Console.WriteLine("Available books:");
        foreach (var book in books)
        {
            Console.WriteLine(book); // Print each book in the list
        }
    }
}