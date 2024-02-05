using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>
        {
            new Book("Pride and Prejudice", "Jane Austen", 1813, 19.99, 50),
            new Book("Hamlet", "William Shakespeare", 1603, 15.50, 30),
            new Book("War and Peace", "Leo Tolstoy", 1869, 25.99, 40)
        };

            int choice;
            do
            {
                
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View All the Books information");
                Console.WriteLine("3. Get the Author details of a specific book");
                Console.WriteLine("4. Sell Copies of a Specific Book");
                Console.WriteLine("5. Restock a Specific Book");
                Console.WriteLine("6. See the count of the Books present in your bookList");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Enter Title: ");
                            string title = Console.ReadLine();
                            Console.Write("Enter Author: ");
                            string author = Console.ReadLine();
                            Console.Write("Enter Publication Year: ");
                            int publicationYear = int.Parse(Console.ReadLine());
                            Console.Write("Enter Price: ");
                            double price = double.Parse(Console.ReadLine());
                            Console.Write("Enter Quantity in Stock: ");
                            int quantityInStock = int.Parse(Console.ReadLine());

                            Book newBook = new Book(title, author, publicationYear, price, quantityInStock);
                            bookList.Add(newBook);
                            Console.WriteLine("Book added successfully!");
                            break;

                        case 2:
                            Console.Clear();
                            foreach (var book in bookList)
                            {
                                Console.WriteLine(book.BookDetails());
                            }
                            break;

                        case 3:
                            Console.Clear();
                            Console.Write("Enter the Title of the book: ");
                            string searchTitle = Console.ReadLine();
                            Book foundBook = bookList.Find(book => book.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase));
                            if (foundBook != null)
                            {
                                Console.WriteLine(foundBook.GetAuthor());
                            }
                            else
                            {
                                Console.WriteLine($"Book with title '{searchTitle}' not found.");
                            }
                            break;

                        case 4:
                            Console.Clear();
                            Console.Write("Enter the Title of the book: ");
                            string sellTitle = Console.ReadLine();
                            Book sellBook = bookList.Find(book => book.Title.Equals(sellTitle, StringComparison.OrdinalIgnoreCase));
                            if (sellBook != null)
                            {
                                Console.Write("Enter the number of copies to sell: ");
                                int numberOfCopiesToSell = int.Parse(Console.ReadLine());
                                sellBook.SellCopies(numberOfCopiesToSell);
                            }
                            else
                            {
                                Console.WriteLine($"Book with title '{sellTitle}' not found.");
                            }
                            break;

                        case 5:
                            Console.Clear();
                            Console.Write("Enter the Title of the book: ");
                            string restockTitle = Console.ReadLine();
                            Book restockBook = bookList.Find(book => book.Title.Equals(restockTitle, StringComparison.OrdinalIgnoreCase));
                            if (restockBook != null)
                            {
                                Console.Write("Enter the number of copies to restock: ");
                                int additionalCopies = int.Parse(Console.ReadLine());
                                restockBook.Restock(additionalCopies);
                            }
                            else
                            {
                                Console.WriteLine($"Book with title '{restockTitle}' not found.");
                            }
                            break;

                        case 6:
                            Console.Clear();
                            Console.WriteLine($"Total number of books in the bookList: {bookList.Count}");
                            break;

                        case 7:
                            Console.WriteLine("Exiting the program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine();
            } while (choice != 7);
        }
        static void ClearConsole()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', Console.WindowWidth * Console.WindowHeight));
            Console.SetCursorPosition(0, 0);
        }
    }
}
