using System;

namespace modul5_1302200087
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo j1 = new SayaTubeVideo("Review Film Batman oleh Arialdi Rahmadi Putra");
            SayaTubeVideo j2 = new SayaTubeVideo("Review Film The Red oleh Arialdi Rahmadi Putra");
            SayaTubeVideo j3 = new SayaTubeVideo("Review Film Sing 2 oleh Arialdi Rahmadi Putra");
            SayaTubeVideo j4 = new SayaTubeVideo("Review Film Jungle Cruise oleh Arialdi Rahmadi Putra");
            SayaTubeVideo j5 = new SayaTubeVideo("Review Film Free Guy oleh Arialdi Rahmadi Putra");
            SayaTubeVideo j6 = new SayaTubeVideo("Review Film Kurang Kejaan oleh Arialdi Rahmadi Putra");
            SayaTubeVideo j7 = new SayaTubeVideo("Review Film Gak tau Apa oleh Arialdi Rahmadi Putra");
            SayaTubeVideo j8 = new SayaTubeVideo("Review Film Lupa Lagi oleh Arialdi Rahmadi Putra");
            SayaTubeVideo j9 = new SayaTubeVideo("Review Film Bingung oleh Arialdi Rahmadi Putra");
            SayaTubeVideo j10 = new SayaTubeVideo("Review Film Mau Ngapain oleh Arialdi Rahmadi Putra");
            SayaTubeUser ss = new SayaTubeUser("Arialdi Rahmadi Putra");

            j1.IncreasePlayCount(1);
            j2.IncreasePlayCount(5);
            j3.IncreasePlayCount(3);
            j4.IncreasePlayCount(2);
            j5.IncreasePlayCount(4);
            j6.IncreasePlayCount(5);
            j7.IncreasePlayCount(8);
            j8.IncreasePlayCount(5);
            j9.IncreasePlayCount(4);
            j10.IncreasePlayCount(2);


            ss.AddVideo(j1);
            ss.AddVideo(j2);
            ss.AddVideo(j3);
            ss.AddVideo(j4);
            ss.AddVideo(j5);
            ss.AddVideo(j6);
            ss.AddVideo(j7);
            ss.AddVideo(j8);
            ss.AddVideo(j9);
            ss.AddVideo(j10);

            j1.PrintVideoDetails();

            ss.PrintAllVideoPlaycount();
        }
    }
}