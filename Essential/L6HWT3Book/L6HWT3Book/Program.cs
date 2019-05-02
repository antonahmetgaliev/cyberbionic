using Common;
using System;
using System.Collections.Generic;

namespace L6HWT3Book
{
    public class Program
    {
        private static List<string> CreateNewBook()
        {
            var subSelect = Menu.CreateMenuInt(new[]
                { "Do you want to enter new book or enter the default book?","New","Default"}
            );
            
            var pageText = new List<string>();
            Console.Clear();
            if (subSelect == 1)
            {
                Console.Write("How many pages u want to see? - ");
                var pages = ConsoleExtension.CheckInt();
                for (var i = 0; i < pages; i++)
                {
                    Console.Write($"Enter text of page №{i + 1}: ");
                    pageText.Add(Console.ReadLine());
                }
            }
            else
            {
                pageText = new List<string>()
                {
                    "1 page book", "2 page book", "3 page book"
                };
            }
            Console.Write("Done! Press any key for continue");
            Console.ReadKey();
            return pageText;
        }

        private static int PageReturn(string act)
        {
            Console.Clear();
            Console.Write($"Which page do you want to {act} a comment? - ");
            return ConsoleExtension.CheckInt();
        }

        private static string CommentReturn()
        {
            Console.Clear();
            Console.Write("\nEnter your comment - ");
            return Console.ReadLine();
        }

        private static void DoAndCheck(Book book, string act)
        {
            try
            {
                switch (act)
                {
                    case "add":
                        book.SetNotes(CommentReturn(), PageReturn(act));
                        break;
                    case "change":
                        book.ChangeNotes(CommentReturn(), PageReturn(act));
                        break;
                    case "delete":
                        book.DeleteNotes(PageReturn(act));
                        break;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("\nError! (Out of range)");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("\nError! (Empty field)");
            }
            catch (Exception)
            {
                Console.WriteLine("\nError!");
            }
        }

        private static void Main()
        {
            var book = new Book(CreateNewBook());
            var body = new[]
            {
                "Menu:", "Enter new book", "Enter new notes", "Change old notes", "Delete old notes", "Show all pages"
            };
            do
            {
                Console.Clear();
                var select = Menu.CreateMenuInt(body);
                switch (select)
                {
                    case 1:
                        Console.Clear();
                        book = new Book(CreateNewBook());
                        ConsoleExtension.WaitingAction();
                        break;
                    case 2:
                        DoAndCheck(book, "add");
                        ConsoleExtension.WaitingAction();
                        break;
                    case 3:
                        DoAndCheck(book, "change");
                        ConsoleExtension.WaitingAction();
                        break;
                    case 4:
                        DoAndCheck(book, "delete");
                        ConsoleExtension.WaitingAction();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Book:");
                        var showBook = book.Show();
                        foreach (var t in showBook)
                        {
                            Console.WriteLine(t);
                        }
                        ConsoleExtension.WaitingAction();
                        break;
                }
            } while (true);
        }
    }
}