using System;
using System.Collections.Generic;
using System.Text;

namespace Within
{
    class Pollen : Actor
    {
        public Pollen(int x, int y) : base(x, y, "........''''", ConsoleColor.Yellow)
        {

        }

        public override void Update()
        {
            Actor collision = Game.ActiveScene.CheckPosition(X + 1, Y);
            if (collision is Grass)
            {
                Grass grass = collision as Grass;

                if (!grass.Tall)
                    grass.Tall = true;
                else
                    grass.Bloom(Color);

                Active = false;
            }

            X++;

            base.Update();
        }
    }
}
