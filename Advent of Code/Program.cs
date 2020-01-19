﻿using System;
using Advent_of_Code.Day_01;
using Advent_of_Code.Day_02;

namespace Advent_of_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            Day_01.Day_01.Run();

            Day_02.Day_02 d2 = new Day_02.Day_02();
            d2.Run();

            Day_03.Day_03 d3 = new Day_03.Day_03();
            d3.Run();

            Day_04.Day_04 d4 = new Day_04.Day_04();
            d4.Run();

            Day_05.Day_05 d5 = new Day_05.Day_05();
            d5.Run();

            Day_06.Day_06 d6 = new Day_06.Day_06();
            d6.Run();

            Day_07.Day_07 d7 = new Day_07.Day_07();
            d7.Run();


            Day_08.Day_08 d8 = new Day_08.Day_08();
            d8.Run();
            
            Day_09.Day_09 d9 = new Day_09.Day_09();
            d9.Run();

            Console.WriteLine("Complete");
        }
    }
}

