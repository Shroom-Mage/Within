using System;
using System.Collections.Generic;
using System.Text;

namespace Within
{
    class Grass : Actor
    {
        private Sprite _bloomUp = new Sprite("v  v v   v ", ConsoleColor.White);
        private Sprite _bloomAngle = new Sprite(" vv v vvv v", ConsoleColor.White);

        public bool Blooming { get; set; }

        public bool Tall
        {
            get { return Animation == "|//|/|///|/"; }
            set
            {
                if (value)
                {
                    Animation = "|//|/|///|/";
                }
                else
                {
                    Animation = ".,,.,.,,,.,";
                    Blooming = false;
                }
            }
        }

        public Grass(int x, int y) : base(x, y, "|//|/|///|/", ConsoleColor.Green)
        {
            
        }

        public override void Draw()
        {
            if (Blooming)
            {
                _bloomUp.Draw(X, Y - 1);
                _bloomAngle.Draw(X + 1, Y - 1);
            }

            base.Draw();
        }

        public void Bloom(ConsoleColor color)
        {
            Blooming = true;
            _bloomUp.Color = color;
            _bloomAngle.Color = color;
            Prairie.AddBloom(this);
        }
    }
}
