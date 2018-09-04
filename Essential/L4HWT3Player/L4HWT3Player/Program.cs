namespace L4HWT3Player
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player:IPlayable, IRecodable
    {
        public void Play()
        {

        }

        public void Pause()
        {

        }

        public void Stop()
        {

        }

        public void Record()
        {

        }
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
