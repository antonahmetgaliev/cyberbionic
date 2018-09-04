using System.IO;

namespace L4HWT1AbstractHandler
{
    internal abstract class AbstractHandler
    {
        private string _path;
        private FileStream _file;
        private StreamWriter _writer;

        public virtual void Open(string name)
        {
            _path = $@"E:\repos\cyberbionic\Essential\L4HWT1AbstractHandler\L4HWT1AbstractHandler\Files\{name}";
            _file = new FileStream(_path, FileMode.Open);
        }

        public virtual bool Create(string name)
        {
            _path = $@"E:\repos\cyberbionic\Essential\L4HWT1AbstractHandler\L4HWT1AbstractHandler\Files\{name}";
            if (File.Exists(_path)) return false;
            _file = new FileStream(_path, FileMode.Create);
            _file.Close();
            return true;
        }

        public virtual void Change(string text)
        {
            _writer = new StreamWriter(_file);
            _writer.Write(text);
            _writer.Close();
        }

        public virtual void Save()
        {
        }
    }
}