﻿using Advent_of_Code.SharedLibrary.IntcodeVirtualMachine;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Advent_of_Code.Day_02
{
    public class Day_02
    {
        private readonly List<int> _initialState = SharedLibrary.FileParser.GetIntCodeFromFile(@"Inputs\Day02Input.txt");


        public void Run()
        {
            Stopwatch stopWatch = Stopwatch.StartNew();

            Console.WriteLine($"=====Day 2, part 1=====");
            Console.WriteLine($"Position 0 in the output: {GetPart1Solution()}");
            Console.WriteLine($"=====Day 2, part 2=====");
            Console.WriteLine($"Position 0 in the output: {GetPart2Solution()}");
            Console.WriteLine("");

            Console.WriteLine($"Day 2 completed in {stopWatch.ElapsedMilliseconds} ms");
            Console.WriteLine();
            Console.WriteLine();
        }

        private long GetPart1Solution()
        {
            List<int> freshInitialState = _initialState.GetRange(0, _initialState.Count);
            IntcodeVirtualMachine intMachine = new IntcodeVirtualMachine(freshInitialState);
            return intMachine.Run();
        }

        private int GetPart2Solution()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    List<int> freshInitialState = _initialState.GetRange(0, _initialState.Count);
                    freshInitialState[1] = i;
                    freshInitialState[2] = j;
                    IntcodeVirtualMachine intMachine = new IntcodeVirtualMachine(freshInitialState);

                    long result = intMachine.Run();
                    if (result == 19690720)
                    {
                        return (100 * i) + j;
                    }
                }
            }

            return 0;
        }
    }
}

