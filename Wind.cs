using System;
using System.Collections.Generic;
using System.Text;

namespace Within
{
    class Wind : Actor
    {
        private Random _random = new Random();

        public Wind() : base(0, 0, "~~~~~~------", ConsoleColor.Cyan)
        {
            X = -_random.Next(Console.WindowWidth*2);
            Y = _random.Next(Console.WindowHeight);
        }

        public override void Update()
        {
            X += 2;

            if (X >= Console.WindowWidth)
            {
                X = -_random.Next(Console.WindowWidth*2);
                Y = _random.Next(Console.WindowHeight);
            }

            base.Update();
        }
    }
}
