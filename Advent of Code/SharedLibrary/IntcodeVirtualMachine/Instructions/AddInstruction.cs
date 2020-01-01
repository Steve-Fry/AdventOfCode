﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Advent_of_Code.SharedLibrary.IntcodeVM.Instructions
{
    class AddInstruction : BinaryOperatorInstruction, IInstruction
    {
        public AddInstruction(int instructionPointer, List<int> program) : base(instructionPointer, program)
        {
        }
        
        public override int Execute()
        {
            program[outputIndex] = Input1Value + Input2Value;
            return instructionPointer + 4;
        }
    }
}
