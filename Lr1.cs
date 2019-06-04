using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ,.?!";
            string alphabet2 = "DEFGHIJKLMNOPQRSTUVWXYZABCdefghijklmnopqrstuvwxyzabc ,.?!";
            ConsoleKeyInfo check;
            do
            {
                Console.Write("Введите предложение для кодировки методом Цезаря: ");
                string text = Console.ReadLine();
                string cipher = "";
                Console.Write("Закодированный текст: ");
                for (int i = 0; i < text.Length; i++)
                {
                    for (int j = 0; j < alphabet1.Length; j++)
                    {
                        if (text[i] == alphabet1[j])
                            cipher = cipher + alphabet2[j];
                    }
                }
                Console.WriteLine(cipher);
                Console.Write("Закончить выполнение программы ? Есди да, нажмите Escape, нет, нажмите любую другую клавишу;\n");
                check = Console.ReadKey();
                Console.Write("\n");
            } while (check.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }
}
