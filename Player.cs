using System;
using System.Collections.Generic;
using System.Text;

namespace Within
{
    class Player : Actor
    {
        public Player(int x, int y) : base(x, y, "@", ConsoleColor.Magenta)
        {

        }

        public override void TimedUpdate()
        {
            switch (Input.GetLastKey())
            {
                case ConsoleKey.A:
                    X--;
                    break;
                case ConsoleKey.D:
                    X++;
                    break;
                case ConsoleKey.W:
                    Y--;
                    break;
                case ConsoleKey.S:
                    Y++;
                    break;
                case ConsoleKey.Spacebar:
                    Game.ActiveScene.AddActor(new Pollen(X, Y - 1));
                    break;
            }

            base.TimedUpdate();
        }
    }
}
