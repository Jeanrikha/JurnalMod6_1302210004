using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210004
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;
            Random random = new Random();
            id = random.Next(10000, 99999);
            playCount = 0;
        }
        public void increasePlayCount(int views)
        {
            this.playCount = views + this.playCount;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID:\t " + id);
            Console.WriteLine("Title:\t " + title);
            Console.WriteLine("Views:\t " + playCount);
        }

        internal bool GetVideoPlayCount()
        {
            throw new NotImplementedException();
        }
        public String getTitle()
        {
            return title;
        }
    }
}
