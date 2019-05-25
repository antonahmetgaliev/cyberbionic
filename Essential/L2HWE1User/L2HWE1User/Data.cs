namespace L2HWE1User
{
    internal class Data
    {
        private readonly User[] _user;
        private string DataInfo { get; }

        public Data(string data)
        {
            _user = new User[10];
            DataInfo = data;
        }

        public void InputUser(string login, string name, string surname, string age, int id)
        {
            _user[id] = new User(login, name, surname, age, DataInfo);
        }

        public void ShowUser(int id)
        {
            _user[id].Show();
        }
    }
}
