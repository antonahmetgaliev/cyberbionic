using System;
using System.Collections.Generic;

namespace L6HWT3Book
{
    internal class Program
    {
        private static List<string> Start(){
            var subSelect = MyLib.CreateMenuInt(new[]
                { "Do you want to enter new book or enter the default book?","New","Default"}
            );
            
            var pageText = new List<string>();
            Console.Clear();
            if (subSelect == 1)
            {
                Console.Write("How many pages u want to see? - ");
                var pages = MyLib.CheckInt();
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
                var select = MyLib.CreateMenuInt(body);
                switch (select)
                {
                    case 1:
                        Console.Clear();
                        book = new Book(Start());
                        MyLib.Done();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Which page do you want to add a comment? - ");
                        var page = MyLib.CheckInt();
                        Console.Write("\nEnter your comment - ");
                        var comment = Console.ReadLine();
                        book.SetNotes(comment, page);
                        MyLib.Done();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Which page do you want to change a comment? - ");
                        page = MyLib.CheckInt();
                        Console.Write("\nEnter your comment - ");
                        comment = Console.ReadLine();
                        book.ChangeNotes(comment, page);
                        MyLib.Done();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Which page do you want to delete a comment? - ");
                        page = MyLib.CheckInt();
                        book.DeleteNotes(page);
                        MyLib.Done();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Book:");
                        var showBook = book.Show();
                        foreach (var t in showBook)
                        {
                            Console.WriteLine(t);
                        }
                        MyLib.Done();
                        break;
                }
            } while (true);
        }
    }
}