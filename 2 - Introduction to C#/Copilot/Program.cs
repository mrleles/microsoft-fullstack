using System;
using System.Collections.Generic;

class LibraryManager
{
    // List to store the books
    static List<string> books = new List<string>();

    static void Main()
    {
        // Infinite loop to keep the program running until the user decides to exit
        while (true)
        {
            Console.WriteLine("Would you like to add or remove a book? (add/remove/exit)");
            string action = Console.ReadLine().ToLower(); // Convert input to lowercase

            if (action == "add")
            {
                AddBook(); // Call AddBook method if user wants to add a book
            }
            else if (action == "remove")
            {
                RemoveBook(); // Call RemoveBook method if user wants to remove a book
            }
            else if (action == "exit")
            {
                break; // Exit the loop if user wants to exit
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
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