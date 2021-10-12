using System;
using System.Collections.Generic;
using System.Text;

namespace Within
{
    static class Input
    {
        private static ConsoleKey _lastkey = 0;

        public static ConsoleKey GetLastKey()
        {
            return _lastkey;
        }

        public static void Update()
        {
            _lastkey = Console.ReadKey(true).Key;
        }
    }
}
