using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore
{
    internal class Book
    {
        public string Title { get; }
        public string Author { get; }
        public int PublicationYear { get; }
        public double Price { get; }
        public int QuantityInStock { get; private set; }

        public Book(string title, string author, int publicationYear, double price, int quantityInStock)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public string GetTitle()
        {
            return $"Title: {Title}";
        }

        public string GetAuthor()
        {
            return $"Author: {Author}";
        }

        public string GetPublicationYear()
        {
            return $"Publication Year: {PublicationYear}";
        }

        public string GetPrice()
        {
            return $"Price: {Price:C}";
        }

        public void SellCopies(int numberOfCopies)
        {
            if (numberOfCopies <= QuantityInStock)
            {
                QuantityInStock -= numberOfCopies;
                Console.WriteLine($"{numberOfCopies} copies of '{Title}' sold. Remaining stock: {QuantityInStock}");
            }
            else
            {
                Console.WriteLine($"Error: Not enough copies of '{Title}' in stock.");
            }
        }

        public void Restock(int additionalCopies)
        {
            QuantityInStock += additionalCopies;
            Console.WriteLine($"{additionalCopies} copies of '{Title}' added to stock. New stock: {QuantityInStock}");
        }

        public string BookDetails()
        {
            return $"Title: {Title}, Author: {Author}, Publication Year: {PublicationYear}, Price: {Price:C}, Quantity in Stock: {QuantityInStock}";
        }
    }
}
