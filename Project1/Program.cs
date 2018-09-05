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
            List<Magazine> magazines = new List<Magazine>();

            books.Add(new Book()
            {
                name = "Harry Potter",
                type = "Book",
                Author = "J.K. Rowling",
                NumPages = "500",
                Supply = 1
            });

            movies.Add(new Movie()
            {
                name = "Interstellar",
                type = "Movie",
                Director = "A Guy",
                Length = "3 hours",
                Supply = 1
            });

            string choice = "";
            int exit = 1;

            Console.WriteLine("Welcome to your media library. What would you like to do?");
            while (exit == 1)
            {
                Console.WriteLine("0: See what's in your library");
                Console.WriteLine("1: Display the information on a specific item");
                Console.WriteLine("2: Add an Item");
                Console.WriteLine("3: Sell an item");
                Console.WriteLine("4: Restock an item");
                Console.WriteLine("5: Exit");
                choice = Console.ReadLine();

                int a = Convert.ToInt32(choice);

                if(a == 0)
                {

                    Console.WriteLine("BOOKS");
                    Console.WriteLine("-----------");

                    foreach (Book i in books)
                    {
                        i.Info();
                    }

                    Console.WriteLine("MOVIES");
                    Console.WriteLine("-----------");

                    foreach (Movie i in movies)
                    {
                        i.Info();
                    }

                    Console.WriteLine("MAGAZINES");
                    Console.WriteLine("-----------");

                    foreach (Magazine i in magazines)
                    {
                        i.Info();
                    }


                }
                else if( a == 1)
                {
                    Console.WriteLine("What is the name of the item?");
                    string item = Console.ReadLine();

                    foreach( Book i in books)
                    {
                        if(item == i.name)
                        {
                            i.Info();
                        }
                    }
                    foreach(Movie i in movies)
                    {
                        if(item == i.name)
                        {
                            i.Info();
                        }
                    }
                    foreach(Magazine i in magazines)
                    {
                        if(item == i.name)
                        {
                            i.Info();
                        }
                    }
                }
                else if (a == 2)
                {
                    string name = "";
                    string type = "";
                    string author = "";
                    string director = "";
                    string length = "";
                    string numpages = "";
                    string mainstor = "";
                    string month = "";
                    string temp = "";
                    int supply = 0;

                    Console.WriteLine("What is the name of your new Item?");
                    name = Console.ReadLine();
                    Console.WriteLine("What is the type of your new Item?");
                    type = Console.ReadLine();
                    Console.WriteLine("How many items do you have right now?");
                    temp = Console.ReadLine();

                    supply = Convert.ToInt32(temp);

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
                            NumPages = numpages,
                            Supply = supply
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
                    else if (type == "magazine" || type == "Magazine")
                    {
                        Console.WriteLine("What is the main story of the magazine?");
                        mainstor = Console.ReadLine();
                        Console.WriteLine("What is the month this issue was released?");
                        month = Console.ReadLine();

                        magazines.Add(new Magazine()
                        {
                            name = name,
                            type = type,
                            MainStor = mainstor,
                            Month = month,
                            Supply = supply

                        });
                    }
                    else
                    {
                        Console.WriteLine("You cannot store that item.");
                    }
                    
                }
                else if (a == 3)
                {
                    int amount = 0;
                    int removalbooks = 255;
                    int removalmovies = 255;
                    int removalmagazines = 255;

                    Console.WriteLine("Which item would you like to sell?");
                    string name = Console.ReadLine();
                                       
                    Console.WriteLine("How many would you like to sell?");
                    string b = Console.ReadLine();

                    amount = Convert.ToInt32(b);

                    foreach (Book i in books)
                    {
                        if (name == i.name)
                        {
                            i.Sell(amount);

                            if (i.Supply == 0)
                            {
                                removalbooks = books.IndexOf(i);
                            }
                            else
                            {
                                removalbooks = 255;
                            }
                        }
                        
                    }

                    

                    foreach (Movie i in movies)
                    {
                        if (name == i.name)
                        {
                            i.Sell(amount);

                            if (i.Supply == 0)
                            {
                                removalmovies = movies.IndexOf(i);
                            }
                            else
                            {
                                removalmagazines = 255;
                            }
                        }
                        
                    }

                    

                    foreach(Magazine i in magazines)
                    {
                        if (name == i.name)
                        {
                            i.Sell(amount);

                            if (i.Supply == 0)
                            {
                                removalmagazines = magazines.IndexOf(i);
                            }
                            else
                            {
                                removalmagazines = 255;
                            }
                        }
                       
                    }

                    if(removalbooks != 255)
                    {
                        books.RemoveAt(removalbooks);
                    }
                    
                    if(removalmovies != 255)
                    {
                        movies.RemoveAt(removalmovies);
                    }

                    if(removalmagazines != 255)
                    {
                        magazines.RemoveAt(removalmagazines);
                    }

                    

                }
                else if (a == 4)
                {
                    string b = "";
                    int amount = 0;
                    string name = "";
                    Console.WriteLine("Which item would you like to restock?");
                    name = Console.ReadLine();
                    Console.WriteLine("How many would you like to restock?");
                    b = Console.ReadLine();

                    amount = Convert.ToInt32(b);

                    foreach (Book i in books)
                    {
                        if (name == i.name)
                        {
                            i.Restock(amount);
                        }
                    }

                    foreach (Movie i in movies)
                    {
                        if (name == i.name)
                        {
                            i.Restock(amount);
                        }
                    }

                    foreach (Magazine i in magazines)
                    {
                        if (name == i.name)
                        {
                            i.Restock(amount);

                        }
                    }
                }
                else if ( a == 5)
                {
                    exit = 0;
                }
                else
                {
                    Console.WriteLine("");
                }

            }
            Console.WriteLine("Thank you please come again");
            Console.ReadLine();
        }
    }
}
