using System;
using System.Collections.Generic;
using System.Text;

namespace Within
{
    class Monster : Actor
    {
        private Actor _target = null;

        public Monster(int x, int y) : base(x, y, "OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO-", ConsoleColor.Red)
        {

        }

        public override void Update()
        {
            if (_target == null && Prairie.BloomList.Count > 0)
            {
                _target = Prairie.BloomList.Last.Value;
            }

            if (_target != null)
            {
                if (_target.Y > Y) Y++;
                else if (_target.Y < Y) Y--;
                if (_target.X > X) X++;
                else if (_target.X < X) X--;
            }

            Actor collision = Game.ActiveScene.CheckPosition(X + 1, Y);
            if (collision is Grass)
            {
                Grass grass = collision as Grass;

                if (grass.Blooming)
                {
                    Prairie.RemoveBloom(grass);
                    grass.Blooming = false;
                    grass.Active = false;
                    _target = null;
                }
                else if (grass.Tall)
                {
                    grass.Tall = false;
                }
            }

            base.Update();
        }
    }
}
