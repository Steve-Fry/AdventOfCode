﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Advent_of_Code.SharedLibrary.IntcodeVM;

namespace Advent_of_Code.Day_07.Tests
{
    public class Day7_Examples_Part2
    {
        [Fact]
        public void ShouldCorrectlyProcessExample1()
        {
            List<int> program = new List<int>() { 3, 26, 1001, 26, -4, 26, 3, 27, 1002, 27, 2, 27, 1, 27, 26, 27, 4, 27, 1001, 28, -1, 28, 1005, 28, 6, 99, 0, 0, 5 };
            FeedbackAmplifierTuner feedbackAmplifierTuner = new FeedbackAmplifierTuner(program);
            feedbackAmplifierTuner.Run();

            int expectedSignal = 139629729;
            List<long> expectedTune = new List<long>() { 9, 8, 7, 6, 5 };
            Assert.Equal(expectedSignal, feedbackAmplifierTuner.HighestOutput);
            Assert.Equal(expectedTune, feedbackAmplifierTuner.OptimalTune);
        }

        [Fact]
        public void ShouldCorrectlyProcessExample2()
        {
            List<int> program = new List<int>() { 3, 52, 1001, 52, -5, 52, 3, 53, 1, 52, 56, 54, 1007, 54, 5, 55, 1005, 55, 26, 1001, 54, -5, 54, 1105, 1, 12, 1, 53, 54, 53, 1008, 54, 0, 55, 1001, 55, 1, 55, 2, 53, 55, 53, 4, 53, 1001, 56, -1, 56, 1005, 56, 6, 99, 0, 0, 0, 0, 10 };
            FeedbackAmplifierTuner feedbackAmplifierTuner = new FeedbackAmplifierTuner(program);
            feedbackAmplifierTuner.Run();

            int expectedSignal = 18216;
            List<long> expectedTune = new List<long>() { 9, 7, 8, 5, 6 };
            Assert.Equal(expectedSignal, feedbackAmplifierTuner.HighestOutput);
            Assert.Equal(expectedTune, feedbackAmplifierTuner.OptimalTune);
        }
    }

}
