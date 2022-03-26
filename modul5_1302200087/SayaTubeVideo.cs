using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302200087
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }
        public void IncreasePlayCount(int a)
        {
            this.playCount += a;
        }
        public int getPlayCount()
        {
            return this.playCount;
        }
        public string getTitle()
        {
            return this.title;
        }
        public void PrintVideoDetails()
        {
            for (int i = 0; i < playCount; i++)
            {

                Console.WriteLine("ID Film : " + this.id);
                Console.WriteLine("Title Film : " + this.title);
                Console.WriteLine("Playcount Film : " + (i + 1));
                Console.WriteLine();
            }
        }
    }
}