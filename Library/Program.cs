using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        public static bool enoughBooks = false;
        static void Main(string[] args)
        {
            Book womanInCage = new Book("Kvinden I Buret", "Jussi Adler Olsen", 114115, 1);
            Book bottlePostFromP = new Book("Flaskepost fra P", "Jussi Adler Olsen", 115116, 2);
            Book thePhilosphersStone = new Book("De Vises Sten", "J.K. Rowling", 116117, 3);
            Book chamberOfSecrets = new Book("Hemmelighedernes Kammer", "J.K. Rowling", 117118, 4);

            List<Book> libraryBooksAvailable = new List<Book>() { womanInCage, bottlePostFromP, thePhilosphersStone, chamberOfSecrets };
            Stack<Book> stackOfBooks = new Stack<Book>();


            int availableBooks = 0;

            Menu.GetHeader();
            while (availableBooks < 4 && enoughBooks == false)
            {


                Console.WriteLine("Disse bøger er tilgængelige for udlån:\n");
                foreach (var book in libraryBooksAvailable)
                {
                    Console.WriteLine($"Titel:  { book.Title }, Forfatter: { book.Author }, Hyldeplacering:  { book.PlaceOnShelf }");

                }

                Console.WriteLine("\n\nAngiv venligst hvilke bøger du vil tage ned fra hylden, brug hyldeplaceringsnumrene som reference.");
                int userLoan = int.Parse(Console.ReadLine());

                switch (userLoan)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine($"Du har lagt {womanInCage.Title} i din kurv.");
                            stackOfBooks.Push(womanInCage);
                            libraryBooksAvailable.Remove(womanInCage);
                            availableBooks++;
                            if (libraryBooksAvailable.Count > 0)
                            {
                                Menu.GetRepeat();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Vi har ikke flere ledige bøger.");
                                enoughBooks = true;
                            }

                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine($"Du har lagt {bottlePostFromP.Title} i din kurv.");
                            stackOfBooks.Push(bottlePostFromP);
                            libraryBooksAvailable.Remove(bottlePostFromP);
                            availableBooks++;
                            if (libraryBooksAvailable.Count > 0)
                            {
                                Menu.GetRepeat();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Vi har ikke flere ledige bøger.");
                                enoughBooks = true;
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine($"Du har lagt {thePhilosphersStone.Title} i din kurv.");
                            stackOfBooks.Push(thePhilosphersStone);
                            libraryBooksAvailable.Remove(thePhilosphersStone);
                            availableBooks++;
                            if (libraryBooksAvailable.Count > 0)
                            {
                                Menu.GetRepeat();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Vi har ikke flere ledige bøger.");
                                enoughBooks = true;
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine($"Du har lagt {chamberOfSecrets.Title} i din kurv.");
                            stackOfBooks.Push(chamberOfSecrets);
                            libraryBooksAvailable.Remove(chamberOfSecrets);
                            availableBooks++;
                            if (libraryBooksAvailable.Count > 0)
                            {
                                Menu.GetRepeat();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Vi har ikke flere ledige bøger.");
                                enoughBooks = true;
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Noget er gået galt.");
                            Menu.GetRepeat();
                            break;
                        }
                }

            }
            Console.WriteLine("Tryk Enter for at komme til skranken hvor du skal tjekke dine bøger ud.\n\n");
            Console.ReadKey();
            Console.Clear();
            Menu.GetCheckOutCounter();

            Console.WriteLine("\nDu har følgende bøger i din kurv:");
            foreach (var book in stackOfBooks)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine("\nTryk Enter for at starte med at skanne dine bøger.\n\n");
            Console.ReadKey();

            Menu.GetCheckOutCounter();

            for (int i = 0; i < stackOfBooks.Count; i++)
            {

                Console.Clear();
                Menu.GetCheckOutCounter();
                Console.WriteLine($"\n{stackOfBooks.Peek().Title } er nu tjekket ud og du har lånt den med hjem.\n");
                stackOfBooks.Pop();

                if (stackOfBooks.Count > 0)
                {
                    
                    Console.WriteLine("Tryk Enter for at skanne din næste bog.\n");
                    Console.ReadKey();
                }

                i = -1;
            }
            Console.WriteLine("Tryk Enter for at forlade biblioteket.");
            Console.ReadKey();
            Console.Clear();
            Menu.GetGoodbye();



        }
    }

    
}

