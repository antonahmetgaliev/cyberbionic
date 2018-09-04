namespace L4HWT3Player
{
    internal class Player:IPlayable, IRecodable
    {
        public string Play()
        {
            return "PLAY";
        }

        public string Pause()
        {
            return "PAUSE";
        }

        public string Stop()
        {
            return "STOP";
        }

        public string Record()
        {
            return "RECORD";
        }
    }
}