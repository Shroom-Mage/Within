using System;
using System.Collections.Generic;
using System.Text;

namespace Within
{
    class Actor
    {
        public bool Active { get; set; } = true;
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        private Sprite _sprite;
        public string Animation
        {
            set { _sprite.Animation = value; }
            get { return _sprite.Animation; }
        }
        public ConsoleColor Color
        {
            set { _sprite.Color = value; }
            get { return _sprite.Color; }
        }

        public Actor(int x, int y, string animation = ".", ConsoleColor color = ConsoleColor.White)
        {
            X = x;
            Y = y;
            _sprite = new Sprite(animation, color);
        }

        public virtual void TimedUpdate()
        {
            
        }

        public virtual void Update()
        {

        }

        public virtual void Draw()
        {
            _sprite.Draw(X, Y);
        }
    }
}
