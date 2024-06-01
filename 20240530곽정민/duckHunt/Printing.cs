using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;

namespace duckHunt
{

    public class Printing
    {
        public static int ScreenWidth = 170;
        public static int ScreenHeight = 50;

        public static void DrawAt(int x, int y, object obj)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(obj.ToString());
        }


        public static void DrawAt(int x, int y, object obj, ConsoleColor clr)
        {
            Console.BackgroundColor = clr;
            DrawAt(x, y, obj);
            Console.ResetColor();
        }





        // 가로 170
        // 세로 50
        public static void ShowMenu()
        {
            for (int i = 1; i < ScreenWidth - 2; i++)
            {
                DrawAt(i, 0, '■');
                Thread.Sleep(1);

            }
            for (int i = 1; i < ScreenHeight - 2; i++)
            {
                DrawAt(ScreenWidth - 2, i, '■');
                Thread.Sleep(1);
            }
            for (int i = ScreenWidth - 2; i > 1; i--)
            {
                DrawAt(i, ScreenHeight - 2, '■');
                Thread.Sleep(1);
            }
            for (int i = ScreenHeight - 2; i > 0; i--)
            {
                DrawAt(1, i, '■');
                Thread.Sleep(1);

            }



            DrawAt(40, 12, @"'########::'##::::'##::'######::'##:::'##::::'##::::'##:'##::::'##:'##::: ##:'########:");
            DrawAt(40, 13, @" ##.... ##: ##:::: ##:'##... ##: ##::'##::::: ##:::: ##: ##:::: ##: ###:: ##:... ##..::");
            DrawAt(40, 14, @" ##:::: ##: ##:::: ##: ##:::..:: ##:'##:::::: ##:::: ##: ##:::: ##: ####: ##:::: ##::::");
            DrawAt(40, 15, @" ##:::: ##: ##:::: ##: ##::::::: #####::::::: #########: ##:::: ##: ## ## ##:::: ##::::");
            DrawAt(40, 16, @" ##:::: ##: ##:::: ##: ##::::::: ##. ##:::::: ##.... ##: ##:::: ##: ##. ####:::: ##::::");
            DrawAt(40, 17, @" ##:::: ##: ##:::: ##: ##::: ##: ##:. ##::::: ##:::: ##: ##:::: ##: ##:. ###:::: ##::::");
            DrawAt(40, 18, @" ########::. #######::. ######:: ##::. ##:::: ##:::: ##:. #######:: ##::. ##:::: ##::::");
            DrawAt(40, 19, @"........::::.......::::......:::..::::..:::::..:::::..:::.......:::..::::..:::::..:::::");
            DrawAt(40, 25, @"                                      (P) lay                                        ");
            DrawAt(40, 26, @"                                                                                     ");
            DrawAt(40, 27, @"                                      (I) nformation                                 ");
            DrawAt(40, 28, @"                                                                                     ");
            DrawAt(40, 29, @"                                      (E) xit                                        ");


        }
        public static void Information()
        {
            Console.Clear();
            for (int i = 1; i < ScreenWidth - 2; i++)
            {
                DrawAt(i, 0, '■');


            }
            for (int i = 1; i < ScreenHeight - 2; i++)
            {
                DrawAt(ScreenWidth - 2, i, '■');

            }
            for (int i = ScreenWidth - 2; i > 1; i--)
            {
                DrawAt(i, ScreenHeight - 2, '■');

            }
            for (int i = ScreenHeight - 2; i > 0; i--)
            {
                DrawAt(1, i, '■');


            }


            DrawAt(40, 12, @"Move : ↑↓←→");
            DrawAt(40, 14, @"Shoot : SpaceBar");
            DrawAt(40, 16, @"Shoot the ducks and Get a higher score");
            DrawAt(40, 18, @"If you run out of bullets, The game will be over");
            DrawAt(40, 20, @"Good Luck and Have Fun!");
            DrawAt(40, 22, @"Credit : Kwak Jeong Min (a.k.a zzangmin)");
            DrawAt(40, 24, @"Thank you for playing this game");
            DrawAt(40, 30, @"Go to Menu : (I)");

            ConsoleKeyInfo a;
            while (true)
            {
                a = Console.ReadKey();
                switch (a.Key)
                {
                    case ConsoleKey.I:
                        Console.Clear();
                        Printing.ShowMenu();
                        Menu.ActiveAtMain();
                        break;

                }
            }



        }


        public static void BeforeGameStart()
        {

            Console.Clear();
            Printing.InGameUI();



            DrawAt(126, 37, @"  ▩          ▩          ▩  ");
            DrawAt(126, 38, @" ■■        ■■        ■■ ");
            DrawAt(126, 39, @"■■■      ■■■      ■■■");
            DrawAt(126, 40, @"■■■      ■■■      ■■■");
            DrawAt(126, 41, @"■■■      ■■■      ■■■");



            Tree();
            Bush();



            for (int i = 0; i < 4; i++)
            {


                DrawAt(44, 3, @"■■■■  ■■■■  ■■■■■          ■■■    ■■■■  ■■■■  ■■■    ■      ■ ");
                DrawAt(44, 4, @"■        ■            ■              ■    ■  ■        ■    ■  ■    ■    ■  ■ ");
                DrawAt(44, 5, @"■  ■■  ■■■        ■              ■■■    ■■■    ■■■■  ■    ■      ■ ");
                DrawAt(44, 6, @"■    ■  ■            ■              ■    ■  ■        ■    ■  ■    ■      ■ ");
                DrawAt(44, 7, @"■■■■  ■■■■      ■              ■     ■ ■■■■  ■    ■  ■■■        ■");

                Thread.Sleep(300);

                DrawAt(44, 3, @"                                                                                                         ");
                DrawAt(44, 4, @"                                                                                                         ");
                DrawAt(44, 5, @"                                                                                                         ");
                DrawAt(44, 6, @"                                                                                                         ");
                DrawAt(44, 7, @"                                                                                                         ");
                Thread.Sleep(300);
            }

            DrawAt(44, 3, @"                                                                                                         ");
            DrawAt(44, 4, @"                                                                                                         ");
            DrawAt(44, 5, @"                                                                                                         ");
            DrawAt(44, 6, @"                                                                                                         ");
            DrawAt(44, 7, @"                                                                                                         ");

            DrawAt(84, 3, @"■■■  ");
            DrawAt(84, 4, @"      ■");
            DrawAt(84, 5, @"  ■■  ");
            DrawAt(84, 6, @"      ■");
            DrawAt(84, 7, @"■■■  ");
            Thread.Sleep(1000);


            DrawAt(84, 3, @"                ");
            DrawAt(84, 4, @"                ");
            DrawAt(84, 5, @"                ");
            DrawAt(84, 6, @"                ");
            DrawAt(84, 7, @"                ");



            DrawAt(84, 3, @"  ■■  ");
            DrawAt(84, 4, @"■    ■");
            DrawAt(84, 5, @"    ■  ");
            DrawAt(84, 6, @"  ■    ");
            DrawAt(84, 7, @"■■■■");

            Thread.Sleep(1000);

            DrawAt(84, 3, @"                ");
            DrawAt(84, 4, @"                ");
            DrawAt(84, 5, @"                ");
            DrawAt(84, 6, @"                ");
            DrawAt(84, 7, @"                ");



            DrawAt(84, 3, @"  ■■  ");
            DrawAt(84, 4, @"■■■  ");
            DrawAt(84, 5, @"  ■■  ");
            DrawAt(84, 6, @"  ■■  ");
            DrawAt(84, 7, @"■■■■");

            Thread.Sleep(1000);


            DrawAt(84, 3, @"                ");
            DrawAt(84, 4, @"                ");
            DrawAt(84, 5, @"                ");
            DrawAt(84, 6, @"                ");
            DrawAt(84, 7, @"                ");

            DrawAt(82, 3, @"■■■■    ■■    ■■");
            DrawAt(82, 4, @"■        ■    ■  ■■");
            DrawAt(82, 5, @"■  ■■  ■    ■  ■■");
            DrawAt(82, 6, @"■    ■  ■    ■      ");
            DrawAt(82, 7, @"■■■■    ■■    ■■");


            Thread.Sleep(800);
            DrawAt(82, 3, @"                                ");
            DrawAt(82, 4, @"                                ");
            DrawAt(82, 5, @"                                ");
            DrawAt(82, 6, @"                                ");
            DrawAt(82, 7, @"                                ");



        }



        public static void InGameUI()
        {
            DrawAt(1, 0, @"■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            DrawAt(1, 1, @"■                                                                                                                                                                    ■");
            DrawAt(1, 2, @"■                                                                                                                                                                    ■");
            DrawAt(1, 3, @"■                                                                                                                                                                    ■");
            DrawAt(1, 4, @"■                                                                                                                                                                    ■");
            DrawAt(1, 5, @"■                                                                                                                                                                    ■");
            DrawAt(1, 6, @"■                                                                                                                                                                    ■");
            DrawAt(1, 7, @"■                                                                                                                                                                    ■");
            DrawAt(1, 8, @"■                                                                                                                                                                    ■");
            DrawAt(1, 9, @"■                                                                                                                                                                    ■");
            DrawAt(1, 10, @"■                                                                                                                                                                    ■");
            DrawAt(1, 11, @"■                                                                                                                                                                    ■");
            DrawAt(1, 12, @"■                                                                                                                                                                    ■");
            DrawAt(1, 13, @"■                                                                                                                                                                    ■");
            DrawAt(1, 14, @"■                                                                                                                                                                    ■");
            DrawAt(1, 15, @"■                                                                                                                                                                    ■");
            DrawAt(1, 16, @"■                                                                                                                                                                    ■");
            DrawAt(1, 17, @"■                                                                                                                                                                    ■");
            DrawAt(1, 18, @"■                                                                                                                                                                    ■");
            DrawAt(1, 19, @"■                                                                                                                                                                    ■");
            DrawAt(1, 20, @"■                                                                                                                                                                    ■");
            DrawAt(1, 21, @"■                                                                                                                                                                    ■");
            DrawAt(1, 22, @"■                                                                                                                                                                    ■");
            DrawAt(1, 23, @"■                                                                                                                                                                    ■");
            DrawAt(1, 24, @"■                                                                                                                                                                    ■");
            DrawAt(1, 25, @"■                                                                                                                                                                    ■");
            DrawAt(1, 26, @"■                                                                                                                                                                    ■");
            DrawAt(1, 27, @"■                                                                                                                                                                    ■");
            DrawAt(1, 28, @"■                                                                                                                                                                    ■");
            DrawAt(1, 29, @"■                                                                                                                                                                    ■");
            DrawAt(1, 30, @"■                                                                                                                                                                    ■");
            DrawAt(1, 31, @"■                                                                                                                                                                    ■");
            DrawAt(1, 32, @"■                                                                                                                                                                    ■");
            DrawAt(1, 33, @"■                                                                                                                                                                    ■");
            DrawAt(1, 34, @"■                                                                                                                                                                    ■");
            DrawAt(1, 35, @"■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            DrawAt(1, 36, @"■                                                                ■                                              ■                                                  ■");
            DrawAt(1, 37, @"■                                                                ■                                              ■                                                  ■");
            DrawAt(1, 38, @"■                                                                ■                                              ■                                                  ■");
            DrawAt(1, 39, @"■                                                                ■                                              ■                                                  ■");
            DrawAt(1, 40, @"■                                                                ■                                              ■                                                  ■");
            DrawAt(1, 41, @"■                                                                ■                                              ■                                                  ■");
            DrawAt(1, 42, @"■                                                                ■                                              ■                                                  ■");
            DrawAt(1, 43, @"■          ■■■    ■■      ■■    ■■■    ■■■■        ■             ■    ■  ■ ■■■■■          ■         ■■■ ■    ■    ■■   ■■■■■     ■");
            DrawAt(1, 44, @"■        ■        ■    ■  ■    ■  ■    ■  ■              ■             ■    ■  ■     ■              ■       ■       ■    ■  ■    ■     ■         ■");
            DrawAt(1, 45, @"■          ■■    ■        ■    ■  ■■■    ■■■          ■             ■■■■  ■     ■              ■         ■■   ■■■■  ■    ■     ■         ■");
            DrawAt(1, 46, @"■              ■  ■    ■  ■    ■  ■    ■  ■              ■             ■    ■  ■     ■              ■             ■ ■    ■  ■    ■     ■         ■");
            DrawAt(1, 47, @"■        ■■■      ■■      ■■    ■     ■ ■■■■        ■             ■    ■  ■     ■              ■       ■■■   ■    ■    ■■       ■         ■");
            DrawAt(1, 48, @"■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");






        }

        public static void GameOver()
        {
            DrawAt(44, 10, @"■■■■  ■■■■    ■  ■   ■■■■            ■■    ■      ■  ■■■■  ■■■");
            DrawAt(44, 11, @"■        ■    ■  ■  ■  ■ ■                ■    ■  ■      ■  ■        ■    ■");
            DrawAt(44, 12, @"■  ■■  ■■■■  ■  ■  ■ ■■■■          ■    ■  ■      ■  ■■■■  ■■■");
            DrawAt(44, 13, @"■    ■  ■    ■  ■      ■ ■                ■    ■    ■  ■    ■        ■    ■");
            DrawAt(44, 14, @"■■■■  ■    ■  ■      ■ ■■■■            ■■        ■      ■■■■  ■     ■");
        }

        public static void GameOverOutOfScore()
        {
            DrawAt(44, 10, @"■■■■  ■■■■    ■  ■   ■■■■            ■■    ■      ■  ■■■■  ■■■");
            DrawAt(44, 11, @"■        ■    ■  ■  ■  ■ ■                ■    ■  ■      ■  ■        ■    ■");
            DrawAt(44, 12, @"■  ■■  ■■■■  ■  ■  ■ ■■■■          ■    ■  ■      ■  ■■■■  ■■■");
            DrawAt(44, 13, @"■    ■  ■    ■  ■      ■ ■                ■    ■    ■  ■    ■        ■    ■");
            DrawAt(44, 14, @"■■■■  ■    ■  ■      ■ ■■■■            ■■        ■      ■■■■  ■     ■");
            DrawAt(44, 20, @"                           Amazing! You Crashed this Game!                                ");
            Console.SetCursorPosition(68, 18);
        }


        public static void ShowScore(Player player)
        {
            int score1 = player.score / 10000;
            int score2 = (player.score % 10000) / 1000;
            int score3 = (player.score % 1000) / 100;
            int score4 = (player.score % 100) / 10;
            int score5 = (player.score % 10);

            switch (score1)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: Numbers(9, score1); break;

            }
            switch (score2)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: Numbers(20, score2); break;

            }
            switch (score3)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: Numbers(31, score3); break;

            }
            switch (score4)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: Numbers(42, score4); break;

            }
            switch (score5)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: Numbers(53, score5); break;

            }

        }

        public static void ShowHit(Player player)
        {
            int hit1 = player.hit / 10;
            int hit2 = player.hit % 10;


            switch (hit1)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: Numbers(82, hit1); break;

            }

            switch (hit2)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: Numbers(93, hit2); break;

            }





        }

        public static void Numbers(int x, int number)
        {
            DrawAt(x, 37, @"          ");
            DrawAt(x, 38, @"          ");
            DrawAt(x, 39, @"          ");
            DrawAt(x, 40, @"          ");
            DrawAt(x, 41, @"          ");

            switch (number)
            {

                case 0:
                    {
                        // 숫자 0
                        DrawAt(x, 37, @"■■■    ");
                        DrawAt(x, 38, @"■    ■  ");
                        DrawAt(x, 39, @"■    ■  ");
                        DrawAt(x, 40, @"■    ■  ");
                        DrawAt(x, 41, @"  ■■■  ");
                        break;
                    }

                case 1:
                    {
                        // 숫자 1       
                        DrawAt(x, 37, @"  ■■    ");
                        DrawAt(x, 38, @"■■■    ");
                        DrawAt(x, 39, @"  ■■    ");
                        DrawAt(x, 40, @"  ■■    ");
                        DrawAt(x, 41, @"■■■■  ");

                        break;
                    }

                case 2:
                    {
                        // 숫자 2       x
                        DrawAt(x, 37, @"  ■■    ");
                        DrawAt(x, 38, @"■    ■  ");
                        DrawAt(x, 39, @"    ■    ");
                        DrawAt(x, 40, @"  ■      ");
                        DrawAt(x, 41, @"■■■■  ");
                        break;
                    }


                case 3:
                    {


                        // 숫자 3       x
                        DrawAt(x, 37, @"■■■    ");
                        DrawAt(x, 38, @"      ■  ");
                        DrawAt(x, 39, @"  ■■    ");
                        DrawAt(x, 40, @"      ■  ");
                        DrawAt(x, 41, @"■■■    ");

                        break;
                    }

                case 4:
                    {


                        // 숫자 4       
                        DrawAt(x, 37, @"■  ■    ");
                        DrawAt(x, 38, @"■  ■    ");
                        DrawAt(x, 39, @"■■■■  ");
                        DrawAt(x, 40, @"    ■    ");
                        DrawAt(x, 41, @"    ■    ");
                        break;
                    }


                case 5:
                    {
                        //숫자 5        x
                        DrawAt(x, 37, @"■■■■  ");
                        DrawAt(x, 38, @"■        ");
                        DrawAt(x, 39, @"■■■■  ");
                        DrawAt(x, 40, @"      ■  ");
                        DrawAt(x, 41, @"■■■■  ");
                        break;
                    }

                case 6:
                    {


                        // 숫자 6       x
                        DrawAt(x, 37, @"  ■■    ");
                        DrawAt(x, 38, @"■        ");
                        DrawAt(x, 39, @"■■■    ");
                        DrawAt(x, 40, @"■    ■  ");
                        DrawAt(x, 41, @"  ■■    ");
                        break;
                    }

                case 7:
                    {
                        // 숫자 7       
                        DrawAt(x, 37, @"■■■■  ");
                        DrawAt(x, 38, @"■    ■  ");
                        DrawAt(x, 39, @"      ■  ");
                        DrawAt(x, 40, @"      ■  ");
                        DrawAt(x, 41, @"      ■  ");
                        break;
                    }

                case 8:
                    {
                        // 숫자 8       x
                        DrawAt(x, 37, @"  ■■    ");
                        DrawAt(x, 38, @"■    ■  ");
                        DrawAt(x, 39, @"  ■■    ");
                        DrawAt(x, 40, @"■    ■  ");
                        DrawAt(x, 41, @"  ■■    ");
                        break;
                    }
                case 9:
                    {
                        // 숫자 9       x
                        DrawAt(x, 37, @"  ■■    ");
                        DrawAt(x, 38, @"■    ■  ");
                        DrawAt(x, 39, @"  ■■■  ");
                        DrawAt(x, 40, @"      ■  ");
                        DrawAt(x, 41, @"      ■  ");
                        break;
                    }
            }

        }











        public static void Tree()
        {


            // 기준 3
            DrawAt(15, 4, @"%**********");
            DrawAt(11, 5, @"(%**************#");
            DrawAt(10, 6, @"(%***************(/");
            DrawAt(11, 7, @"%****************&&");
            DrawAt(11, 8, @"/%&*%***********/%&%");
            DrawAt(14, 9, @"&%&&&*%%#&%*/%&");

            DrawAt(18, 10, @"/(/&/");
            DrawAt(31, 10, @"***********");

            DrawAt(19, 11, @"/&&/");
            DrawAt(28, 11, @"*****************");

            DrawAt(17, 12, @"((*%&&");
            DrawAt(27, 12, @"(****************%");

            DrawAt(20, 13, @"/&&#");
            DrawAt(27, 13, @"/***************%%");

            DrawAt(21, 14, @"#&&/***/%%%*%*******%%&");

            DrawAt(22, 15, @"&&&******/&#&&&&%&%");

            DrawAt(7, 16, @"**********");
            DrawAt(21, 16, @"#**************");

            DrawAt(6, 17, @"(***********((**&(&*(*&**(((/");

            DrawAt(5, 18, @"%%************%#");
            DrawAt(23, 18, @"(&&*%&&");
            DrawAt(38, 18, @"********");

            DrawAt(5, 19, @"&&&***********&%");
            DrawAt(24, 19, @"(&&*&&&");
            DrawAt(35, 19, @"***************");

            DrawAt(7, 20, @"((%&&#&&##%#/");
            DrawAt(23, 20, @"(&&&&(");
            DrawAt(33, 20, @"(#***************#/");

            DrawAt(13, 21, @"%%(/&/");
            DrawAt(23, 21, @"(&&&&");
            DrawAt(32, 21, @"/%&/***************/&");

            DrawAt(17, 22, @"&&(");
            DrawAt(23, 22, @"(&&&%");
            DrawAt(31, 22, @"/&//*(***********&*&#");

            DrawAt(19, 23, @"/&&(");
            DrawAt(24, 23, @"%&&&%");
            DrawAt(34, 23, @"/#&&#%&/&##&#*%#%/");

            DrawAt(21, 24, @"&&&&&&&&");
            DrawAt(36, 24, @"(&&%*#*/#**//");

            DrawAt(22, 25, @"#&&&&&&");
            DrawAt(34, 25, @"&&&&&");

            DrawAt(23, 26, @"(&&&&&#");
            DrawAt(31, 26, @"#&&&#");

            DrawAt(24, 27, @"%&&&&&&&&&");
            DrawAt(24, 28, @"(&&&&&&&%");
            DrawAt(24, 29, @"(&&&&&&(");
            DrawAt(24, 30, @"(&&&&&&");
            DrawAt(24, 31, @"(&&&&&&");
            DrawAt(24, 32, @"(&&&&&&");
            DrawAt(24, 33, @"#&&&&&&");
            DrawAt(24, 34, @"&&&&&&&");



        }

        public static void Bush()
        {

            DrawAt(136, 27, "#&******");
            DrawAt(134, 28, "#&/********");
            DrawAt(133, 29, "#&&&/********");
            DrawAt(131, 30, "/&&***%********");
            DrawAt(129, 31, "%&%*&(************");
            DrawAt(128, 32, "(&&&&(*((*******(**(");
            DrawAt(129, 33, "&&&&&&&*&*******#*&%");
            DrawAt(125, 34, ",%/&&&&&&&&&&,%&%&&*(&&&* ");


        }



    }
}
