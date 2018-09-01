using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Book> books = new List<Book>();
            List<Movie> movies = new List<Movie>();

            books.Add(new Book()
            {
                name = "Harry Potter",
                type = "Book",
                Author = "J.K. Rowling",
                NumPages = "500"
            });

            movies.Add(new Movie()
            {
                name = "Interstellar",
                type = "Movie",
                Director = "A Guy",
                Length = "3 hours"
            });

            string choice = "";
            int exit = 1;

            Console.WriteLine("Welcome to your media library. What would you like to do?");
            while (exit == 1)
            {
                exit = 1;
                Console.WriteLine("0: Add an Item");
                Console.WriteLine("1: See what's in your library");
                Console.WriteLine("2: Sell an item");
                Console.WriteLine("3: Restock an item");
                Console.WriteLine("4: Exit");
                choice = Console.ReadLine();

                int a = Convert.ToInt32(choice);

                if(a == 0)
                {
                    string name = "";
                    string type = "";
                    string author = "";
                    string director = "";
                    string length = "";
                    string numpages = "";

                    Console.WriteLine("What is the name of your new Item?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is the type of your new Item?");
                    type = Console.ReadLine();

                    if (type == "book" || type == "Book")
                    {
                        Console.WriteLine("Who is the author of the book?");
                        author = Console.ReadLine();
                        Console.WriteLine("How many pages are in the book?");
                        numpages = Console.ReadLine();

                        books.Add(new Book()
                        {
                            name = name,
                            type = type,
                            Author = author,
                            NumPages = numpages

                        });

                    }
                    else if (type == "movie" || type == "Movie")
                    {
                        Console.WriteLine("Who is the director of the movie?");
                        director = Console.ReadLine();
                        Console.WriteLine("How long is the movie?");
                        length = Console.ReadLine();

                        movies.Add(new Movie()
                        {
                            name = name,
                            type = type,
                            Director = director,
                            Length = length

                        });

                    }
                    else
                    {
                        Console.WriteLine("You cannot store that item.");
                    }
                    
                }
                else if (a == 1)
                {
                    
                    foreach(Book i in books)
                    {
                        Console.WriteLine("Name: " + i.name);
                        Console.WriteLine("Type: " +i.type);
                        Console.WriteLine("Author: " + i.Author);
                        Console.WriteLine("Number of Pages: " + i.NumPages);
                    }

                    foreach (Movie i in movies)
                    {
                        Console.WriteLine("Name: " + i.name);
                        Console.WriteLine("Type: " + i.type);
                        Console.WriteLine("Director: " + i.Director);
                        Console.WriteLine("Length: " + i.Length);
                    }

                }
                else if (a == 2)
                {
                    string b = "";
                    int amount = 0;
                    Console.WriteLine("How many would you like to sell?");
                    b = Console.ReadLine();

                    amount = Convert.ToInt32(b);

                }
                else if (a == 3)
                {
                    string b = "";
                    int amount = 0;
                    Console.WriteLine("How many would you like to restock?");
                    b = Console.ReadLine();

                    amount = Convert.ToInt32(b);
           
                }
                else if ( a == 4)
                {
                    exit = 0;
                }

            }
            Console.WriteLine("Thank you please come again");
        }
    }
}
