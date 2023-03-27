
using modul6_1302210004;

class main
{
    public static void Main(String[] args)
    {
        SayaTubeUser User = new SayaTubeUser("Review Film");
        for(int i = 0;i < 10; i++)
        {
            Console.WriteLine("Masukkan Judul Film: ");
            String film = "Review Film " + Console.ReadLine() + " Oleh Jean";
            SayaTubeVideo videos = new SayaTubeVideo(film);
            User.AddVideo(videos);
        }
        User.PrintAllVideoPlayCount();
        Console.WriteLine();

        Console.WriteLine("Masukkan Username Anda: ");
        SayaTubeVideo Vid = new SayaTubeVideo(Console.ReadLine());
        Vid.PrintVideoDetails();
    }
}