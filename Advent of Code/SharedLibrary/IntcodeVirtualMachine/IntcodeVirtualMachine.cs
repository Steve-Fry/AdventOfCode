﻿using System;
using System.Collections.Generic;
using System.Text;

using Advent_of_Code.SharedLibrary.IntcodeVirtualMachine.Instructions;
using Advent_of_Code.SharedLibrary.IntcodeVirtualMachine;
using Advent_of_Code.SharedLibrary.IntcodeVirtualMachine.Input_OutputProviders;

namespace Advent_of_Code.SharedLibrary.IntcodeVM
{
    class IntcodeVirtualMachine
    {
        List<int> program;
        int instructionPointer;
        bool isDone = false;

        IInputProvider inputProvider;
        IOutputProvider outputProvider;


        public IntcodeVirtualMachine(List<int> program, IInputProvider inputProvider = null, IOutputProvider outputProvider = null)
        {
            this.program = program;
            instructionPointer = 0;
            isDone = false;


            this.inputProvider = inputProvider ?? new ConsoleInputProvider();
            this.outputProvider = outputProvider ?? new ConsoleOutputProvider();
        }

        public int Run()
        {
            while (isDone == false) { Step(); }
            return program[0];
        }

        public void Step()
        {
            IInstruction instruction = InstructionFactory.GetInstruction(instructionPointer, program, inputProvider, outputProvider);

            if (instruction is StopInstruction)
            {
                isDone = true;
            }
            else
            {
                instructionPointer = instruction.Execute();
            }
        }

        public string GetStateAsString()
        {
            return String.Join(",", program);
        }
        public List<int> GetState()
        {
            return program;
        }
    }
}
