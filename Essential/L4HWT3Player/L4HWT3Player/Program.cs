using System;
using L4HWT1AbstractHandler;

namespace L4HWT3Player
{
    internal class Program
    {
        private static void Main()
        {
            IPlayable play = new Player();
            IRecodable record = new Player();
            var menu = new Menu();
            string doMenu = null;
            do
            {
                var body = new[]
                {
                    "", "Play", "Pause", "Stop", "Record"
                };
                var select = menu.CreateMenuStr(body, doMenu);
                switch (select)
                {
                    case "Play":
                        doMenu = play.Play();
                        break;
                    case "Pause":
                        doMenu = play.Pause();
                        break;
                    case "Stop":
                        doMenu = play.Stop();
                        break;
                    case "Record":
                        doMenu = record.Record();
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
    }
}
