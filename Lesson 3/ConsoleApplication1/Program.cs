﻿using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание и инициализация целочисленных переменных
            int x = 10, y = 12, z = 3;

            //Отображение результата следующей операции x += y - x++ * z (=-8).
            Console.WriteLine("1-е уравнение = {0}", x += y - x++ * z);

            //Восстановление значений переменных к изначальным.
            x = 10;
            y = 12;
            z = 3;

            //Отображение результата следующей операции z = --x - y * 5 (=-51).
            Console.WriteLine("2-е уравнение = {0}", z = --x - y * 5);

            x = 10;
            y = 12;
            z = 3;

            //Отображением результата следующей операции y /= x + 5 % z (=1).
            Console.WriteLine("3-е уравнение = {0}", y /= x + 5 % z);

            x = 10;
            y = 12;
            z = 3;

            //Отображение результата следующей операции z = x++ + y * 5 (=-70).
            Console.WriteLine("4-е уравнение = {0}", z = x++ + y * 5);

            x = 10;
            y = 12;
            z = 3;

            //Отображение результата следующей операции x = y - x++ * z (=-18).
            Console.WriteLine("5-е уравнение = {0}", x = y - x++ * z);

            // Delay.
            Console.ReadKey();
        }
    }
}