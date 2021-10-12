using System;
using System.Collections.Generic;
using System.Text;

namespace Within
{
    class Prairie : Scene
    {
        private Random _random = new Random();

        public static LinkedList<Grass> BloomList = new LinkedList<Grass>();

        public Prairie()
        {
            //Create grass
            for (int y = 0; y < Console.WindowHeight; y++)
            {
                for (int x = 0; x < Console.WindowWidth; x++)
                {
                    if (_random.Next() % 50 == 0)
                    {
                        Grass grass = new Grass(x, y);
                        AddActor(grass);
                        if (_random.Next() % 2 == 0)
                        {
                            grass.Tall = false;
                        }

                    }
                }
            }
            //Create wind
            for (int i = 0; i < 9; i++)
            {
                AddActor(new Wind());
            }
            //Create monster
            Monster monster = new Monster(Console.WindowWidth - 5, Console.WindowHeight - 5);
            AddActor(monster);
            //Create player
            Player player = new Player(5, 5);
            AddActor(player);
        }

        public static void AddBloom(Grass bloom)
        {
            BloomList.AddLast(bloom);
        }

        public static void RemoveBloom(Grass bloom)
        {
            if (BloomList.Remove(bloom))
            {
                bloom.Blooming = false;
                bloom.Tall = false;
            }
        }
    }
}
