﻿using System.Collections.Generic;
using Xunit;
using Advent_of_Code.SharedLibrary.IntcodeVirtualMachine.Input_OutputProviders;

namespace Advent_of_Code.SharedLibrary.IntcodeVirtualMachine.Tests
{
    public class Test_IntCodeMachine_Day5_Part2
    {

        [Fact]
        public void ShouldCorrectlyCalculatePart2()
        {
            string filename = System.IO.Path.GetTempFileName();

            List<int> program = SharedLibrary.FileParser.GetIntCodeFromFile(@"Inputs\Day05Input.txt");
            int expected = 3419022;

            IntcodeVirtualMachine intcodeVirtualMachine = new IntcodeVirtualMachine(program, new StaticInputProvider(new List<long>() { 5 }), new FileOutputProvider(filename));
            intcodeVirtualMachine.Run();

            string actual = System.IO.File.ReadAllText(filename);
            Assert.Equal(expected.ToString(), actual);
        }
    }
}


