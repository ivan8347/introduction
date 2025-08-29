//#define FACTORIAL
//#define MULTIPLICATION
//#define MULTIPLICATION_1
//#define DATATYPSE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if DATATYPSE
            byte var1 = 0;
            Console.WriteLine($"{var1.GetType()} занимает {sizeof(byte)}Байт памяти,и принимает значение в диапазоне:{byte.MinValue}.....{byte.MaxValue}");
            short var3 = 0;
            Console.WriteLine($"{var3.GetType()} занимает {sizeof(short)}Байт памяти,и принимает значение в диапазоне:{short.MinValue}.....{short.MaxValue}");
            int var2 = 0;
            Console.WriteLine($"{var2.GetType()} занимает {sizeof(int)}Байт памяти,и принимает значение в диапазоне:{int.MinValue}.....{int.MaxValue}");
            long var4 = 0;
            Console.WriteLine($"{var4.GetType()} занимает {sizeof(long)}Байт памяти,и принимает значение в диапазоне:{long.MinValue}.....{long.MaxValue}");
            float f = 1;
            Console.WriteLine(f.GetType());
            double f_2 = 1;
            Console.WriteLine(f_2.GetType());
            decimal f_3 = 2;
            Console.WriteLine(f_3.GetType());
#endif


#if FACTORIAL
            Console.Write("Введите число для вычесления факториала:  ");
            int n = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}!= {f * i} ");
                f *= i;
            }
            Console.WriteLine($"Факториал числа {n} равен {f} ");

#endif
            while (true)
            {
                Console.WriteLine($"Введите уравнение в одну строку: ");
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                double a = double.Parse(parts[0]);
                char s = char.Parse(parts[1]);
                double b = double.Parse(parts[2]);
                double c;
                switch (s)
                {
                    case '+': c = a + b;  Console.WriteLine($" {a} + {b} = {c}"); break;
                    case '-': c = a - b; Console.WriteLine($" {a} - {b} = {c}"); break;
                    case '*': c = a * b; Console.WriteLine($" {a} * {b} = {c}"); break;
                    case '/': c = a / b; Console.WriteLine($" {a} / {b} = {c}"); break;

                }
            } 

            


#if MULTIPLICATION
            Console.WriteLine("\t\t\tТаблица умножения \n");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 2; j <= 5; j++)
                {
                    int c = i * j;
                    Console.Write($" {j} * {i} = {c} \t\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 6; j <= 9; j++)
                {
                    int c = i * j;
                    Console.Write($" {j} * {i} = {c} \t\t ");
                }
                Console.WriteLine();
            }

#endif

#if MULTIPLICATION_1

            Console.WriteLine("\t\t\tТаблица умножения \n");


            Console.WriteLine();
            while (true)
            {
               // PrintTable();
                // Создаем случайный генератор
                Random rand = new Random();

                // Определяем часть таблицы
                bool fromFirstPart = rand.Next(0, 2) == 0; // 0 или 1

                int numI = rand.Next(1, 11); // 1-10
                int numJ;

                if (fromFirstPart)
                {
                    numJ = rand.Next(2, 10); // 2-5
                }
                else
                {
                    numJ = rand.Next(6, 10); // 6-9
                }

                int correctAnswer = numJ * numI;

                // Вывод вопроса с выделением цветом

                Console.WriteLine($"\tПосчитайте: {numJ} * {numI} = ?");


                // Запоминаем выбранный пример для выделения в таблице
                var highlightedExample = (J: numJ, I: numI, Answer: correctAnswer);

                // Запрос ответа пользователя
                Console.Write("\tВаш ответ: ");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                if (int.TryParse(userInput, out int userAnswer))
                {
                    if (userAnswer == highlightedExample.Answer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tУРА!!! \n");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Beep();
                        Console.WriteLine($"\tОшибка! {highlightedExample.J} * {highlightedExample.I} = {highlightedExample.Answer} \n");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите числовой ответ.");
                }

                // Воспроизведение таблицы с выделением
                // Первая часть таблицы
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 2; j <= 5; j++)
                    {
                        int c = i * j;
                        if (j == highlightedExample.J && i == highlightedExample.I)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($" {j} * {i} = {c} \t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write($" {j} * {i} = {c} \t");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                // Вторая часть таблицы
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 6; j <= 9; j++)
                    {
                        int c = i * j;
                        if (j == highlightedExample.J && i == highlightedExample.I)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($" {j} * {i} = {c} \t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write($" {j} * {i} = {c} \t");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n-----------------------------------------------\n");
            }
#endif

        }



    }
    
}
