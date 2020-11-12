using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;

namespace Fillwords
{
    class Menu
    {
        static string[] body = new string[] { "Новая игра", "Продолжить", "Рейтинг", "Выход" };
        static string[] head = new string[]
        {   @"  _____ _ _ ___        __            _     ",
            @" |  ___(_) | \ \      / /__  _ __ __| |___ ",
            @" | |_  | | | |\ \ /\ / / _ \| '__/ _` / __|",
            @" |  _| | | | | \ V  V / (_) | | | (_| \__ \",
            @" |_|   |_|_|_|  \_/\_/ \___/|_|  \__,_|___/",
            @"                                           ",
        };
        static int point = 0;
        public static void DrawHead()
        {
            for (int i = 0; i < 6; i++)
            {
                int y = i + 1;
                Console.SetCursorPosition(GetIndent(head[i]), y);
                Console.WriteLine(head[i]);
            }
        }

        public static void DrawBody()
        {
            int x = 0;
            for (int i = 0; i < 4; i++)
            {
                int y = i + 8 + x;
                Console.SetCursorPosition(GetIndent(body[i]), y);
                x++;
                if (point == i) Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(body[i]);
                Console.ResetColor();
            }
        }

        public static void DrawMenu()
        {
            ConsoleKeyInfo key;
            Console.SetWindowSize(100, 50);
            do
            {
                Console.Clear();
                DrawHead();
                DrawBody();
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow) point--;
                if (key.Key == ConsoleKey.DownArrow) point++;
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    DefineButton();
                    break;
                }
                if (point < 0) point = 3;
                if (point > 3) point = 0;
            } while (key.Key != ConsoleKey.Escape);
        }

        public static int GetIndent(string text)
        {
            return (100 - text.Length) / 2;
        }

        public static void DefineButton()
        {
            if (point == 0) Console.WriteLine("Тут однажды будет Новая игра");
            if (point == 1) Console.WriteLine("Тут однажды будет Продолжить");
            if (point == 2) Console.WriteLine("Тут однажды будет Рейтинг");
            if (point == 3) Console.WriteLine("Тут однажды будет Выход");
        }
    }
}
