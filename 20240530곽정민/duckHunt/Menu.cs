using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace duckHunt
{
    class Menu
    {
        static ConsoleKeyInfo a;

        public static void ActiveAtMain()
        {

            
            while (true)
            {

                a = Console.ReadKey();
                switch (a.Key)
                {
                    case ConsoleKey.P:
                        { Game game = new Game();
                            game.GameStart(); break;
                        }
                    case ConsoleKey.I:
                        {
                            Printing.Information();
                            break;
                        }
                    case ConsoleKey.E: { Environment.Exit(0); } break;
                    default:
                        break;
                }
            }
            

        }




    }
}
