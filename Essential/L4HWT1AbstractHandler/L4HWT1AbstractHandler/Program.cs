using System;
using System.IO;
using L2HWT3Employee;

namespace L4HWT1AbstractHandler
{
    abstract class AbstractHandler
    {
        public abstract void Open(string name);
        public abstract bool Create(string name);
        public abstract void Change(string text);
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        private string _path;
        private FileStream _file;
        private StreamWriter _writer;

        public override void Change(string text)
        {
            _writer.Write(text);
        }

        public override bool Create(string name)
        {
            _path = $@"E:\repos\cyberbionic\Essential\L4HWT1AbstractHandler\L4HWT1AbstractHandler\Files\{name}.xml";
            if (File.Exists(_path)) return false;
            File.Create(_path);
            return true;

        }

        public override void Open(string name)
        {
            _path = $@"E:\repos\cyberbionic\Essential\L4HWT1AbstractHandler\L4HWT1AbstractHandler\Files\{name}.xml";
            _file = new FileStream(_path, FileMode.Open);
            _writer = new StreamWriter(_file);
        }

        public override void Save()
        {
            _writer.Close();
        }
    }

    class TXTHandler : AbstractHandler
    {
        private string _path;
        private FileStream _file;
        private StreamWriter _writer;
        
        public override void Change(string text)
        {
            _writer = new StreamWriter(_file);
            _writer.Write(text);
        }

        public override bool Create(string name)
        {
            _path = $@"E:\repos\cyberbionic\Essential\L4HWT1AbstractHandler\L4HWT1AbstractHandler\Files\{name}.txt";
            if (File.Exists(_path)) return false;
            File.Create(_path);
            return true;

        }

        public override void Open(string name)
        {
            _path = $@"E:\repos\cyberbionic\Essential\L4HWT1AbstractHandler\L4HWT1AbstractHandler\Files\{name}.txt";
            _file = new FileStream(_path, FileMode.Open);
        }

        public override void Save()
        {
            _writer.Close();
        }
    }

    class DOCHandler : AbstractHandler
    {
        private string _path;
        private FileStream _file;
        private StreamWriter _writer;

        public override void Change(string text)
        {
            _writer.Write(text);
        }

        public override bool Create(string name)
        {
            _path = $@"E:\repos\cyberbionic\Essential\L4HWT1AbstractHandler\L4HWT1AbstractHandler\Files\{name}.doc";
            if (File.Exists(_path)) return false;
            File.Create(_path);
            return true;

        }

        public override void Open(string name)
        {
            _path = $@"E:\repos\cyberbionic\Essential\L4HWT1AbstractHandler\L4HWT1AbstractHandler\Files\{name}.doc";
            _file = new FileStream(_path, FileMode.Open);
            _writer = new StreamWriter(_file);
        }

        public override void Save()
        {
            _writer.Close();
        }
    }

    internal class Program
    {
        private static void Main()
        {
            var menu = new Menu();
            do
            {
                var body = new[]
                {
                    "Select document type", "XML", "TXT", "DOC"
                };
                var select = menu.CreateMenuStr(body);
                AbstractHandler file;
                switch (select)
                {
                    case "XML":
                        file = new XMLHandler();
                        WorkWithDocument(file);
                        break;
                    case "TXT":
                        file = new TXTHandler();
                        WorkWithDocument(file);
                        break;
                    case "DOC":
                        file = new DOCHandler();
                        WorkWithDocument(file);
                        break;
                }
            } while (menu.Try());
        }

        private static void WorkWithDocument(AbstractHandler file)
        {
            Console.Clear();
            Console.Write("Enter name of file - ");
            var nameOfFile = Console.ReadLine();
            file.Create(nameOfFile);
            file.Open(nameOfFile);
            Console.Write("Enter new text in your document - ");
            var text = Console.ReadLine();
            file.Change(text);
            file.Save();
        }
    }
}
