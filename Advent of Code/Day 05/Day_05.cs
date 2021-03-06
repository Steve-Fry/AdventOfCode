﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using Advent_of_Code.SharedLibrary.IntcodeVirtualMachine;
using Advent_of_Code.SharedLibrary.IntcodeVirtualMachine.Input_OutputProviders;


namespace Advent_of_Code.Day_05
{
    class Day_05
    {
        public void Run()
        {
            Stopwatch stopWatch = Stopwatch.StartNew();

            List<int> program = SharedLibrary.FileParser.GetIntCodeFromFile(@"Inputs\Day05Input.txt");

            Console.WriteLine($"=====Day 5, part 1=====");
            IntcodeVirtualMachine intcodeVirtualMachine = new IntcodeVirtualMachine(program, new StaticInputProvider(new List<long>() { 1 }), new FileOutputProvider("Day5Part1.txt"));
            intcodeVirtualMachine.Run();
            Console.WriteLine($"Output = {System.IO.File.ReadAllText("Day5Part1.txt")}");


            program = SharedLibrary.FileParser.GetIntCodeFromFile(@"Inputs\Day05Input.txt");
            Console.WriteLine($"=====Day 5, part 2=====");
            intcodeVirtualMachine = new IntcodeVirtualMachine(program, new StaticInputProvider(new List<long>() { 5 }), new FileOutputProvider("Day5Part2.txt"));
            intcodeVirtualMachine.Run();
            Console.WriteLine($"Output = {System.IO.File.ReadAllText("Day5Part2.txt")}");
            Console.WriteLine("");


            Console.WriteLine($"Day 5 completed in {stopWatch.ElapsedMilliseconds} ms");
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
