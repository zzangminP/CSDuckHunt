using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Media;
namespace duckHunt
{
    
    public class Program
    {



        //해상도
        public static int ScreenWidth = 170;
        public static int ScreenHeight = 50;



        static void Main(string[] args)
        {
            //음악 재생
            SoundPlayer Musicplayer = new SoundPlayer();
            Musicplayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\8_Bit_Menu_David_Renda.wav";
            Musicplayer.Play();



            Game game = new Game();

            Console.SetWindowSize(ScreenWidth, ScreenHeight);
            Console.SetBufferSize(ScreenWidth+20, ScreenHeight);
            Console.CursorVisible = false;



            game.Gameinit();



        }

    
    }
}



