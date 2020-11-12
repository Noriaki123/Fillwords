using System;
using System.Collections.Generic;
using System.Text;

namespace Fillwords
{
    class Menu
    {
        public static void DrawHead()
        {
            Console.WriteLine(GetIndent(28) + @"  _____ _ _ ___        __            _     ");
            Console.WriteLine(GetIndent(28) + @" |  ___(_) | \ \      / /__  _ __ __| |___ ");
            Console.WriteLine(GetIndent(28) + @" | |_  | | | |\ \ /\ / / _ \| '__/ _` / __|");
            Console.WriteLine(GetIndent(28) + @" |  _| | | | | \ V  V / (_) | | | (_| \__ \");
            Console.WriteLine(GetIndent(28) + @" |_|   |_|_|_|  \_/\_/ \___/|_|  \__,_|___/");
            Console.WriteLine(GetIndent(28) + @"                                           ");
        }

        public static void DrawBody()
        {
            Console.WriteLine(GetIndent(45) + "Новая игра");
            Console.WriteLine();
            Console.WriteLine(GetIndent(45) + "Продолжить");
            Console.WriteLine();
            Console.WriteLine(GetIndent(46) + "Рейтинг");
            Console.WriteLine();
            Console.WriteLine(GetIndent(47) + "Выход");
        }

        public static void DrawMenu()
        {
            Console.SetWindowSize(100, 50);
            DrawHead();
            DrawBody();
        }

        public static string GetIndent(int n)
        {
            string indent = "";
            for (int i = 0; i < n; i++)
            {
                indent = indent + " ";
            }
            return indent;
        }
    }
}
