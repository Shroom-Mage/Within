using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Within
{
    class Game
    {
        public static bool GameOver { get; set; }
        public static Scene ActiveScene { get; set; }

        public Game(int windowWidth = 96, int windowHeight = 36)
        {
            Console.SetWindowSize(windowWidth, windowHeight);

            Console.CursorVisible = false;

            Prairie scene = new Prairie();

            ActiveScene = scene;

        }

        public void Run()
        {
            while (!GameOver && Input.GetLastKey() != ConsoleKey.Escape)
            {
                TimedUpdate();
                while (!Console.KeyAvailable)
                {
                    Console.Clear();
                    Update();
                    Draw();
                    Thread.Sleep(50);
                    Console.ResetColor();
                }
                Input.Update();
            }
            Console.SetCursorPosition(0, 0);
        }

        public bool TimedUpdate()
        {
            return ActiveScene.TimedUpdate();
        }

        public void Update()
        {
            ActiveScene.Update();
        }

        public void Draw()
        {
            ActiveScene.Draw();
        }
    }
}
