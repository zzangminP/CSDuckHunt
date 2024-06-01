using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace duckHunt
{

    public class Duck
    {

        public Point judgePoint;
        
        public int duckStartX;
        public int duckStartY;

        //0이면 왼쪽 -> 오른쪽
        //1이면 오른쪽 -> 왼쪽
        int leftOrRight; 



        public Duck()
        {
            this.judgePoint = new Point(0, 0);
            Random rnd = new Random(unchecked((int)DateTime.Now.Ticks));
            this.duckStartY = rnd.Next(5, 29);
            this.leftOrRight = rnd.Next(0, 2);


        }

        
        public void setPosition(Duck duck)
        {
            

            Random rnd = new Random();


            duck.leftOrRight = rnd.Next(0, 2);
            duck.duckStartY = rnd.Next(5, 30);
            if (duck.leftOrRight == 0)
            {
                duck.duckStartX = 10;
                duck.judgePoint.X = duck.duckStartX+3;
                duck.judgePoint.Y = duck.duckStartY+1;
            }
            else
            {
                duck.duckStartX = 152;
                duck.judgePoint.X = duck.duckStartX+3;
                duck.judgePoint.Y = duck.duckStartY+1;

            }

        }


        public void Move(int duckSprite, Player player)
        {
            //this.setPosition();
            if(leftOrRight == 0)
            {
                this.MoveToRight(duckSprite, player);
                this.judgePoint.X = duckStartX+3;
                this.judgePoint.Y = duckStartY+1;
            }
            else
            {
                this.MoveToLeft(duckSprite, player);
                this.judgePoint.X = duckStartX+3;
                this.judgePoint.Y = duckStartY+1;
            }
        }


        public void Clear()
        {
            if (this.duckStartX >= 160)
            {

                Printing.DrawAt(this.duckStartX - 1, this.duckStartY, @"         ");
                Printing.DrawAt(this.duckStartX - 1, this.duckStartY + 1, @"         ");
                Printing.DrawAt(this.duckStartX - 1, this.duckStartY + 2, @"         ");
                Printing.DrawAt(this.duckStartX - 1, this.duckStartY + 3, @"         ");


                Printing.DrawAt(1, duckStartY, @"■                                                                                                                                                                    ■");
                Printing.DrawAt(1, duckStartY + 1, @"■                                                                                                                                                                    ■");
                Printing.DrawAt(1, duckStartY + 2, @"■                                                                                                                                                                    ■");
                Printing.DrawAt(1, duckStartY + 3, @"■                                                                                                                                                                    ■");

                setPosition(this);

            }
            if(this.duckStartX <= 5)
            {
                Printing.DrawAt(this.duckStartX, this.duckStartY, @"          ");
                Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @"          ");
                Printing.DrawAt(this.duckStartX, this.duckStartY + 2, @"          ");
                Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"         ");


                Printing.DrawAt(1, duckStartY, @"■                                                                                                                                                                    ■");
                Printing.DrawAt(1, duckStartY + 1, @"■                                                                                                                                                                    ■");
                Printing.DrawAt(1, duckStartY + 2, @"■                                                                                                                                                                    ■");
                Printing.DrawAt(1, duckStartY + 3, @"■                                                                                                                                                                    ■");

                setPosition(this);
            }


        }

        public void Dead(Duck duck, Player player)
        {
            if (duck.leftOrRight == 0)
            {
                Printing.DrawAt(this.duckStartX, this.duckStartY, @"         ");
                Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @"         ");
                Printing.DrawAt(this.duckStartX-1, this.duckStartY + 2, @"         ");
                Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"         ");

            }
            else
            {
                Printing.DrawAt(this.duckStartX, this.duckStartY, @"         ");
                Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @"         ");
                Printing.DrawAt(this.duckStartX-1, this.duckStartY + 2, @"          ");
                Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"         ");
            }
            duck.Clear();
            Update(player);
            duck.setPosition(duck);
            player.bullets = 3;
            player.hit++;
            if (player.hit > 9)
            {
                player.score += 250;
                player.hit = 10;
            }
            else if(player.hit>7)
            {
                player.score += 175;
                
            }
            else if(player.hit >2)
            {
                player.score += 110;
            }
            else
            {
                player.score += 100;
            }
            
        }

        /*
        public void MoveToRight(int frame, Player player)
        {



            switch (frame)
            {


                case 1:
                    {
                        if (duckStartX >= 165)
                        {
                            duckStartX = 12;
                            Clear();
                            break;
                        }

                        Update(player);
                        //frame 1
                        Printing.DrawAt(this.duckStartX, this.duckStartY, @"  M   _  ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @" _|M_(a)<");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 2, @"\\____)  ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"         ");

                        if (this.duckStartX > 11)
                        {
                            Printing.DrawAt(this.duckStartX - 9, this.duckStartY, @"         ");
                            Printing.DrawAt(this.duckStartX - 9, this.duckStartY + 1, @"         ");
                            Printing.DrawAt(this.duckStartX - 9, this.duckStartY + 2, @"         ");
                            Printing.DrawAt(this.duckStartX - 9, this.duckStartY + 3, @"         ");

                        }

                        Update(player);
                        duckStartX++;
                        Clear();



                    }
                    break;

                case 2:
                    {
                        if (duckStartX >= 165)
                        {
                            duckStartX = 12;
                            Clear();
                            break;

                        }
                        Update(player);
                        //frame 2
                        Printing.DrawAt(this.duckStartX, this.duckStartY, @"      _  ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @" ____(a)<");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 2, @"\\____)  ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"         ");
                        if (this.duckStartX > 11)
                        {
                            Printing.DrawAt(this.duckStartX - 9, this.duckStartY, @"         ");
                            Printing.DrawAt(this.duckStartX - 9, this.duckStartY + 1, @"         ");
                            Printing.DrawAt(this.duckStartX - 9, this.duckStartY + 2, @"         ");
                            Printing.DrawAt(this.duckStartX - 9, this.duckStartY + 3, @"         ");
                        }
                        Update(player);
                        duckStartX++;
                        Clear();

                    }
                    break;

                case 0:
                    {
                        if (duckStartX >= 165)
                        {
                            duckStartX = 12;

                            Clear();
                            break;

                        }
                        Update(player);
                        //frame 3
                        Printing.DrawAt(this.duckStartX, this.duckStartY, @"      _  ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @" ____(a)<");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 2, @"\\____)  ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"  WW     ");

                        if (this.duckStartX > 11)
                        {
                            Printing.DrawAt(this.duckStartX - 9, this.duckStartY, @"         ");
                            Printing.DrawAt(this.duckStartX - 9, this.duckStartY + 1, @"         ");
                            Printing.DrawAt(this.duckStartX - 9, this.duckStartY + 2, @"         ");
                            Printing.DrawAt(this.duckStartX - 9, this.duckStartY + 3, @"         ");
                        }

                        Update(player);
                        duckStartX++;
                        Clear();

                    }
                    break;


            }


        }

        public void MoveToLeft(int frame, Player player)
        {

            switch (frame)
            {
                case 1:
                    {

                        if (duckStartX <= 5)
                        {
                            duckStartX = 152;
                            Clear();
                            break;
                        }

                        Update(player);
                        //frame 1
                        Printing.DrawAt(this.duckStartX, this.duckStartY, @"  _   M  ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @">(a)_M|_ ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 2, @"  (____/ ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"         ");

                        if (this.duckStartX < 149)
                        {
                            Printing.DrawAt(this.duckStartX+9, this.duckStartY, @"         ");
                            Printing.DrawAt(this.duckStartX+9, this.duckStartY + 1, @"         ");
                            Printing.DrawAt(this.duckStartX+9, this.duckStartY + 2, @"         ");
                            Printing.DrawAt(this.duckStartX + 9, this.duckStartY + 3, @"         ");
                        }

                        Update(player);
                        duckStartX--;
                        Clear();
                    }
                    break;

                case 2:
                    {
                        if (duckStartX <= 5)
                        {
                            duckStartX = 152;
                            Clear();
                            break;
                        }

                        Update(player);
                        //frame 2
                        Printing.DrawAt(this.duckStartX, this.duckStartY, @"  _      ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @">(a)____ ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 2, @"  (____/ ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"         ");

                        if (this.duckStartX < 149)
                        {
                            Printing.DrawAt(this.duckStartX+9, this.duckStartY, @"         ");
                            Printing.DrawAt(this.duckStartX+9, this.duckStartY + 1, @"         ");
                            Printing.DrawAt(this.duckStartX+9, this.duckStartY + 2, @"         ");
                            Printing.DrawAt(this.duckStartX + 9, this.duckStartY + 3, @"         ");
                        }
                        Update(player);
                        duckStartX--;
                        Clear();
                    }
                    break;

                case 0:
                    {
                        if (duckStartX <= 5)
                        {
                            duckStartX = 152;
                            Clear();
                            break;
                        }
                        Update(player);
                        //frame 3
                        Printing.DrawAt(this.duckStartX, this.duckStartY, @"  _      ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @">(a)____ ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 2, @"  (____/ ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"     WW  ");
                        if (this.duckStartX < 149)
                        {
                            Printing.DrawAt(this.duckStartX + 9, this.duckStartY, @"         ");
                            Printing.DrawAt(this.duckStartX + 9, this.duckStartY + 1, @"         ");
                            Printing.DrawAt(this.duckStartX + 9, this.duckStartY + 2, @"         ");
                            Printing.DrawAt(this.duckStartX + 9, this.duckStartY + 3, @"         ");
                        }
                        Update(player);
                        duckStartX--;
                        Clear();

                    }
                    break;
            }



        }
        */




        public void MoveToRight(int frame, Player player)
        {



            switch (frame)
            {


                case 1:
                    {
                        if (duckStartX >= 165)
                        {
                            duckStartX = 12;
                            Clear();
                            break;
                        }

                        Update(player);
                        //frame 1
                        Printing.DrawAt(this.duckStartX, this.duckStartY, @"  M   _  ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @" _|M_(a)<");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 2, @"\\____)  ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"         ");

                        if (this.duckStartX > 10)
                        {
                            Printing.DrawAt(this.duckStartX - 1, this.duckStartY, @" ");
                            Printing.DrawAt(this.duckStartX - 1, this.duckStartY + 1, @" ");
                            Printing.DrawAt(this.duckStartX - 1, this.duckStartY + 2, @"  ");
                            Printing.DrawAt(this.duckStartX - 1, this.duckStartY + 3, @" ");

                        }

                        Update(player);
                        duckStartX++;
                        Clear();



                    }
                    break;

                case 2:
                    {
                        if (duckStartX >= 165)
                        {
                            duckStartX = 12;
                            Clear();
                            break;

                        }
                        Update(player);
                        //frame 2
                        Printing.DrawAt(this.duckStartX, this.duckStartY, @"      _  ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @" ____(a)<");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 2, @" \____)  ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"         ");
                        if (this.duckStartX > 10)
                        {
                            Printing.DrawAt(this.duckStartX - 1, this.duckStartY, @" ");
                            Printing.DrawAt(this.duckStartX - 1, this.duckStartY + 1, @" ");
                            Printing.DrawAt(this.duckStartX - 1, this.duckStartY + 2, @" ");
                            Printing.DrawAt(this.duckStartX - 1, this.duckStartY + 3, @" ");
                        }
                        Update(player);
                        duckStartX++;
                        Clear();

                    }
                    break;

                case 0:
                    {
                        if (duckStartX >= 165)
                        {
                            duckStartX = 12;

                            Clear();
                            break;

                        }
                        Update(player);
                        //frame 3
                        Printing.DrawAt(this.duckStartX, this.duckStartY, @"      _  ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @" ____(a)<");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 2, @" \____)  ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"  WW     ");

                        if (this.duckStartX > 10)
                        {
                            Printing.DrawAt(this.duckStartX - 1, this.duckStartY, @" ");
                            Printing.DrawAt(this.duckStartX - 1, this.duckStartY + 1, @" ");
                            Printing.DrawAt(this.duckStartX - 1, this.duckStartY + 2, @" ");
                            Printing.DrawAt(this.duckStartX - 1, this.duckStartY + 3, @" ");
                        }

                        Update(player);
                        duckStartX++;
                        Clear();

                    }
                    break;


            }


        }

        public void MoveToLeft(int frame, Player player)
        {

            switch (frame)
            {
                case 1:
                    {

                        if (duckStartX <= 5)
                        {
                            duckStartX = 152;
                            Clear();
                            break;
                        }

                        Update(player);
                        //frame 1
                        Printing.DrawAt(this.duckStartX, this.duckStartY, @"  _   M  ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @">(a)_M|_ ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 2, @"  (____/ ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"         ");

                        if (this.duckStartX < 149)
                        {
                            Printing.DrawAt(this.duckStartX + 10, this.duckStartY, @" ");
                            Printing.DrawAt(this.duckStartX + 10, this.duckStartY + 1, @" ");
                            Printing.DrawAt(this.duckStartX + 10, this.duckStartY + 2, @"  ");
                            Printing.DrawAt(this.duckStartX + 10, this.duckStartY + 3, @" ");
                        }

                        Update(player);
                        duckStartX--;
                        Clear();
                    }
                    break;

                case 2:
                    {
                        if (duckStartX <= 5)
                        {
                            duckStartX = 152;
                            Clear();
                            break;
                        }

                        Update(player);
                        //frame 2
                        Printing.DrawAt(this.duckStartX, this.duckStartY, @"  _      ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @">(a)____ ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 2, @"  (____/ ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"         ");

                        if (this.duckStartX < 149)
                        {
                            Printing.DrawAt(this.duckStartX + 10, this.duckStartY, @" ");
                            Printing.DrawAt(this.duckStartX + 10, this.duckStartY + 1, @" ");
                            Printing.DrawAt(this.duckStartX + 10, this.duckStartY + 2, @" ");
                            Printing.DrawAt(this.duckStartX + 10, this.duckStartY + 3, @" ");
                        }
                        Update(player);
                        duckStartX--;
                        Clear();
                    }
                    break;

                case 0:
                    {
                        if (duckStartX <= 5)
                        {
                            duckStartX = 152;
                            Clear();
                            break;
                        }
                        Update(player);
                        //frame 3
                        Printing.DrawAt(this.duckStartX, this.duckStartY, @"  _      ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 1, @">(a)____ ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 2, @"  (____/ ");
                        Printing.DrawAt(this.duckStartX, this.duckStartY + 3, @"     WW  ");
                        if (this.duckStartX < 149)
                        {
                            Printing.DrawAt(this.duckStartX + 10, this.duckStartY, @" ");
                            Printing.DrawAt(this.duckStartX + 10, this.duckStartY + 1, @" ");
                            Printing.DrawAt(this.duckStartX + 10, this.duckStartY + 2, @" ");
                            Printing.DrawAt(this.duckStartX + 10, this.duckStartY + 3, @" ");
                        }
                        Update(player);
                        duckStartX--;
                        Clear();

                    }
                    break;
            }

        }

        public void Update(Player player)
        {

            Printing.Tree();
            Printing.Bush();
            player.crosshair.Draw();
        }

    }
}
