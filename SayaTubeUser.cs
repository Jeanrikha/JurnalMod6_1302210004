using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302210004
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uplodedVideos;
        String Username;
        private int playCount;

        public SayaTubeUser(String Username)
        {
            this.Username = Username;
            uplodedVideos = new List<SayaTubeVideo>();

        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (SayaTubeVideo saya in uplodedVideos) ;
            total += uplodedVideos.Count;

            return total;
        }
        public int GetVideoPlayCount()
        {
            return playCount;
        }
        public void AddVideo (SayaTubeVideo video) 
        {
            Debug.Assert(video!= null);
            //Debug.Assert(video.GetVideoPlayCount());
            uplodedVideos.Add(video);

        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User:\t" + Username);
            foreach (SayaTubeVideo saya in uplodedVideos)
            {
                Console.WriteLine("Judul:\t" + saya.getTitle());
            }
                
        }
    }
}
