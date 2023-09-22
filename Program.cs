using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace ConsoleApp.lessons1
{
    internal class Modul01
    {
        static void zadanie5()
        {

            Console.WriteLine("Ведите ФИО:");
            string FIO = Console.ReadLine();

            Console.WriteLine("Добрый день," + FIO);
        }
        static void zadanie6()
        {
            int a, b;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите 1 число:");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ведите число коректно!!!");
                    continue;
                }
                break;
            }
            while (true)
            {
                try
                {

                    Console.WriteLine("Введите 2 число:");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ведите число коректно!!!");
                    continue;
                }
                break;
            }
            int c = a + b;
            Console.WriteLine("Cумма двух чисел:" + c);


        }

        static void Main()
        {
            zadanie5();
            zadanie6();
        }

    }

}