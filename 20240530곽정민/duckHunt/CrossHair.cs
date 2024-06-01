using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duckHunt
{
    public class CrossHair
    {
        public int ScreenWidth = 170;
        public int ScreenHeight = 50;
        public Point point;
        public Point judgePoint;
        public CrossHair()
        {
            this.point = new Point(ScreenWidth / 2, ScreenHeight / 3);
            this.judgePoint = this.point;
        }


        public void MoveUp()
        {
            if ((this.point.Y - 1) < 5) return;
            Clear();
            this.point.Y--;
            this.judgePoint.Y--;
            Draw();
            
        }


        public void MoveDown()
        {
            if ((this.point.Y + 1) > 33) return;
            Clear();
            this.point.Y++;
            this.judgePoint.Y++;
            Draw();
        
        
        }

        public void MoveRight()
        {
            if ((this.point.X + 2) >= ScreenWidth-12) return;
            Clear();
            this.point.X++;
            this.judgePoint.X++;
            Draw();

        }

        public void MoveLeft()
        {
            if ((this.point.X - 1) < 4) return;
            Clear();
            this.point.X--;
            this.judgePoint.X--;
            Draw();

        }
        public void Miss(Player player)
        {
            player.bullets--;
            player.hit = 0;
        }

        //판정
        public void Shoot(Player player, Duck duck)
        {

            
            //판정
            int judgeX = Math.Abs(player.crosshair.judgePoint.X - (duck.judgePoint.X + 3));
            int judgeY = Math.Abs(player.crosshair.judgePoint.Y - (duck.judgePoint.Y + 3));

            int hideOnBushX = duck.judgePoint.X;
            int hideOnBushY = duck.judgePoint.Y;

            //나무 판정
            if(hideOnBushX >=10 && hideOnBushX<=21 && hideOnBushY >=4 && hideOnBushY<=9)
            {
                //miss

                //       % **********
                //   (% **************#   
                //  (% ***************(/
                //   % ****************&&
                //   /% &*% ***********/% &%
                //      &%&& &*%%#&%*/%&  

                Miss(player);
            }
            else if(hideOnBushX >=18 && hideOnBushX<=23 && hideOnBushY >=10 && hideOnBushY <=14)
            {
                //miss
                //  / (/ &/
                //   /&&/
                // ((*%&&
                //    /&&#
                Miss(player);
            }
            else if(hideOnBushX >=27 && hideOnBushX<=42 && hideOnBushY>=10 && hideOnBushY <=14)
            {
                //miss
                // 
                //       ***********   
                //    *****************
                //   (****************%
                //   /***************%%
                Miss(player);
            }
            else if(hideOnBushX >= 4 && hideOnBushX <=43 && hideOnBushY >=18 && hideOnBushY <=19)
            {
                //miss
                Miss(player);
            }
            else if(hideOnBushX >=6 && hideOnBushX <= 46 && hideOnBushY >=20 && hideOnBushY <=21)
            {
                Miss(player);
            }

            else if(hideOnBushX >= 14 && hideOnBushX <=48 && hideOnBushY >=22 && hideOnBushY <=24)
            {
                Miss(player);
            }
            else if (hideOnBushX >= 22 &&  hideOnBushX<=39 && hideOnBushY >=25 && hideOnBushY<=28)
            {
                Miss(player);
            }
            else if(hideOnBushX >= 22 && hideOnBushX <= 30 && hideOnBushY >=29 && hideOnBushY<=34)
            {
                Miss(player);
            }
            else if(hideOnBushX >=6 && hideOnBushX <=28 && hideOnBushY >=16 && hideOnBushY <=18)
            {
                //miss
                Miss(player);
            }
            else if(hideOnBushX >=21 && hideOnBushX <=34 && hideOnBushY>=14 && hideOnBushY<=15)
            {
                

                Miss(player);

            }
            //오른쪽 부쉬 판정
            else if(hideOnBushX >=133 && hideOnBushX <=145 && hideOnBushY >=27 && hideOnBushY<=28)
            {
                Miss(player);
            }
            else if(hideOnBushX >=130 && hideOnBushX <=147 && hideOnBushY >=29 && hideOnBushY <=30)
            {
                Miss(player);
            }
            else if(hideOnBushX >= 127 && hideOnBushX <= 150 && hideOnBushY >=31 && hideOnBushY <=34)
            {
                Miss(player);
            }
            //그냥 맞췄을때
            else if(12 >= judgeX && 4 >= judgeY)
            {
                
                duck.Dead(duck, player);
                
                
            }
            //그냥 빚맞췄을때
            else
            {
                Miss(player);
            }

            ShowBullets(player);

        }

        public void ShowBullets(Player player)
        {
            if(player.bullets == 3)
            {
                Printing.DrawAt(126, 37, @"  ▩          ▩          ▩  ");
                Printing.DrawAt(126, 38, @" ■■        ■■        ■■ ");
                Printing.DrawAt(126, 39, @"■■■      ■■■      ■■■");
                Printing.DrawAt(126, 40, @"■■■      ■■■      ■■■");
                Printing.DrawAt(126, 41, @"■■■      ■■■      ■■■");
            }
            else if(player.bullets == 2)
            {
                Printing.DrawAt(126, 37, @"  ▩          ▩              ");
                Printing.DrawAt(126, 38, @" ■■        ■■             ");
                Printing.DrawAt(126, 39, @"■■■      ■■■            ");
                Printing.DrawAt(126, 40, @"■■■      ■■■            ");
                Printing.DrawAt(126, 41, @"■■■      ■■■            ");
            }
            else if(player.bullets == 1)
            {
                Printing.DrawAt(126, 37, @"  ▩                          ");
                Printing.DrawAt(126, 38, @" ■■                         ");
                Printing.DrawAt(126, 39, @"■■■                        ");
                Printing.DrawAt(126, 40, @"■■■                        ");
                Printing.DrawAt(126, 41, @"■■■                        ");
            }
            else
            {
                Printing.DrawAt(126, 37, @"                              ");
                Printing.DrawAt(126, 38, @"                              ");
                Printing.DrawAt(126, 39, @"                              ");
                Printing.DrawAt(126, 40, @"                              ");
                Printing.DrawAt(126, 41, @"                              ");
            }
        }



        public void Draw()
        {
            Printing.DrawAt(this.point.X+3, this.point.Y,   @"│");
            Printing.DrawAt(this.point.X+3, this.point.Y-1, @"│");
            Printing.DrawAt(this.point.X, this.point.Y-2, @"── ○──");
            Printing.DrawAt(this.point.X+3, this.point.Y-3, @"│");
            Printing.DrawAt(this.point.X+3, this.point.Y-4, @"│");

        }

        public void Clear()
        {
            Printing.DrawAt(this.point.X+3, this.point.Y, @" ");
            Printing.DrawAt(this.point.X+3, this.point.Y - 1, @" ");
            Printing.DrawAt(this.point.X, this.point.Y - 2, @"          ");
            Printing.DrawAt(this.point.X+3, this.point.Y - 3, @" ");
            Printing.DrawAt(this.point.X+3, this.point.Y - 4, @" ");

        }
    }
}
