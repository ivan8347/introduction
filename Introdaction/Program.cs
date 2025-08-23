//#define STRING_OPERACION
#define DATA_TYPES
#define FACTORIAL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if STRING_OPERACION

            //Console.Write("Hello .NET\n");
            //Console.WriteLine("Привет");
            Console.Write("Введите Ваше имя: ");
            string first_name = Console.ReadLine();
            Console.Write("Введите Вашу фамилию: ");
            string last_name = Console.ReadLine();
            Console.Write("Введите Вашу возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(first_name + " " + last_name + " " + age);
            Console.WriteLine(String.Format("{0} {1} {2}", first_name, last_name, age));
            Console.WriteLine($"{first_name} {last_name} {age}");

#endif
#if DATA_TYPES

             Console.WriteLine(sizeof(bool));
             // Console.WriteLine(Boolean.);
             bool var1;
             Boolean var2;
             Console.WriteLine(sizeof(char));
            // Console.WriteLine(Char);
            short var3 = 0;
             Console.WriteLine(
             $"{var3.GetType()} занимает {sizeof(short)}Байт памяти,и принимает значение в диапазоне:{short.MinValue}.....{short.MaxValue}");






#endif


#if FACTORIAL

            Console.Write("Введите целое число для вычисления факториала: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}! = {f * i}");
                f *= i;
            }
            Console.WriteLine($"Факториал числа {n} равен {f}");

#endif
        }
    }
}
