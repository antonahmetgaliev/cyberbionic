namespace L7HWT2Train
{
    public struct Train
    {
        private readonly string _destination;
        private readonly int _trainNumber;
        private readonly string _departureTime;

        public Train(string destination, int trainNumber, string departureTime)
        {
            _destination = destination;
            _trainNumber = trainNumber;
            _departureTime = departureTime;
        }


        public string Destination => _destination;
        public int TrainNumber => _trainNumber;
        public string DepartureTime => _departureTime;
    }
}