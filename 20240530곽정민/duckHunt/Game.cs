using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Media;

namespace duckHunt
{


    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }
    }

    public class Player
    {
        public int bullets = 3;
        public int hit = 0;
        public int score = 0;
        public CrossHair crosshair = new CrossHair();

        public Player(int bullets, int hit, int score, CrossHair crosshair)
        {
            this.bullets = bullets;
            this.hit = hit;
            this.score = score;
            this.crosshair = crosshair; ;
        }

    }

    public class Game
    {

        public static int frame;
        public static int Spawndelay;


        public void Gameinit()
        {
            Printing.ShowMenu();
            Menu.ActiveAtMain();



        }

        public void GameStart()
        {

            //스크린 170 * 50
            //버퍼 190 * 50

            CrossHair crosshair = new CrossHair();

            Player player = new Player(3, 0, 0, crosshair); ;




            Printing.BeforeGameStart();
            Duck duck1 = new Duck();
            Duck duck2 = new Duck();
            double d1dstc;
            double d2dstc;
            //본 게임이 시작되는 시점
            while (true)
            {


                if (duck1.duckStartY == duck2.duckStartY)
                {
                    duck2.setPosition(duck2);
                }

                if(player.score >=99990)
                {
                    Printing.GameOverOutOfScore();
                    Environment.Exit(0);
                }

                Printing.ShowScore(player);
                Printing.ShowHit(player);

                //오리1, 오리2 거리 계산
                d1dstc = Math.Sqrt(Math.Pow((double)(player.crosshair.judgePoint.X) - (double)(duck1.judgePoint.X), 2) + Math.Pow((double)(player.crosshair.judgePoint.Y) - (double)(duck1.judgePoint.Y), 2));//Math.Sqrt(Math.Pow(((double)(player.crosshair.judgePoint.X) - (double)(duck1.judgePoint.X),2))+ Math.Pow((double)(player.crosshair.judgePoint.Y) - (double)(duck1.judgePoint.Y), 2),2));
                d2dstc = Math.Sqrt(Math.Pow((double)(player.crosshair.judgePoint.X) - (double)(duck2.judgePoint.X), 2) + Math.Pow((double)(player.crosshair.judgePoint.Y) - (double)(duck2.judgePoint.Y), 2));



                if (player.bullets == 0)
                {
                    Printing.GameOver();
                    Console.SetCursorPosition(70, 20);
                    Environment.Exit(0);
                }
                else
                {


                    Thread.Sleep(1000 / 60);



                    while (Console.KeyAvailable)
                    {



                        if (crosshair.point.X <= 10 || crosshair.point.Y <= 30)
                        {
                            crosshair.Draw();

                        }

                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.UpArrow: player.crosshair.MoveUp(); break;
                            case ConsoleKey.DownArrow: player.crosshair.MoveDown(); break;
                            case ConsoleKey.LeftArrow: player.crosshair.MoveLeft(); break;
                            case ConsoleKey.RightArrow: player.crosshair.MoveRight(); break;
                            case ConsoleKey.Spacebar:
                                {
                                    //오리1이 더 멀리 있는 경우
                                    if(d1dstc > d2dstc)
                                    {
                                        //오리2 판정
                                        player.crosshair.Shoot(player, duck2);
                                    }
                                    //오리2가 더 멀리 있는경우
                                    else if(d1dstc < d2dstc)
                                    {
                                        //오리1 판정
                                        player.crosshair.Shoot(player, duck1);
                                    }
                                    //둘다 같은 거리에 있을 경우
                                    else
                                    {
                                        //둘다 판정
                                        player.crosshair.Shoot(player, duck1);
                                        player.crosshair.Shoot(player, duck2);
                                    }

                                    
                                }
                                break; // shoot
                            case ConsoleKey.Escape: Environment.Exit(0); break;

                        }


                    }
                    //break;


                }


                //오리 스프라이트

                Random rnd = new Random();
                int currentTick = System.Environment.TickCount % 1000;
                int duckSprite1 = currentTick % 3;
                int duckSprite2 = (currentTick + rnd.Next(0, 55)) % 3;

                duck1.Move(duckSprite1, player);
                duck2.Move(duckSprite2, player);





            }






        }


    }


}
