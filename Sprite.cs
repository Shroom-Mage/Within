using System;
using System.Collections.Generic;
using System.Text;

namespace Within
{
    class Sprite
    {
        public string Animation { set; get; }
        public ConsoleColor Color { set; get; }

        private int _currentFrame = 0;

        public Sprite(string frames, ConsoleColor color)
        {
            Animation = frames;
            Color = color;
        }

        public void Draw(int x, int y)
        {
            //Check out of bounds
            if (x < 0 || x >= Console.WindowWidth || y < 0 || y >= Console.WindowHeight)
                return;
            //Draw current frame
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = Color;
            if (Animation[_currentFrame] != ' ')
                Console.Write(Animation[_currentFrame]);
            Console.ResetColor();
            //Advance to next frame
            if (_currentFrame < Animation.Length - 1)
                _currentFrame++;
            else
                _currentFrame = 0;
        }
    }
}
