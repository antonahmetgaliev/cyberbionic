using Common;
using System;
using System.Collections.Generic;

namespace L6HWT3Book
{
    internal class Program
    {
        private static List<string> Start(){
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
                    Console.WriteLine($"Enter text of page №{i + 1}:");
                    pageText[i] = Console.ReadLine();
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

        private static string Show(Book book, string act)
        {
            if (act == "delete")
                return book.DeleteNotes(PageReturn(act)) ? "\nDone!" : "\nError!";
            return book.SetNotes(CommentReturn(), PageReturn(act)) ? "\nDone!" : "\nError!";
        }
        
        private static void Main()
        {
            var book = new Book(Start());
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
                        book = new Book(Start());
                        ConsoleExtension.WaitingAction();
                        break;
                    case 2:
                        Console.WriteLine(Show(book, "add"));
                        ConsoleExtension.WaitingAction();
                        break;
                    case 3:
                        Console.WriteLine(Show(book, "change"));
                        ConsoleExtension.WaitingAction();
                        break;
                    case 4:
                        Console.WriteLine(Show(book, "delete"));
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