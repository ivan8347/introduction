using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           


            int x = 30; // начальные координаты по горизонтали
            int y = 10;  // начальные координаты по вертикали
            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false; // скрываем курсор

            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);

                Console.Write("SPU-411"); // символ
                Console.ForegroundColor = ConsoleColor.Red;

                keyInfo = Console.ReadKey(true); // ожидаем нажатие, не выводим символ
                
                
                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        if (y > 0) y--;
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                    case ConsoleKey.S:
                       // Console.Beep();
                        if (y < Console.WindowHeight - 1) y++;
                        break;
                    case ConsoleKey.A:
                        if (x > 0) x--;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case ConsoleKey.D:
                        if (x < Console.WindowWidth - 1) x++;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                       
                    case ConsoleKey.Escape:
                        return; // выход из программы по Esc
                }
            }
            
        }

    }
    
}
