﻿using Advent_of_Code.SharedLibrary.IntcodeVirtualMachine.Input_OutputProviders;
using Advent_of_Code.SharedLibrary.IntcodeVirtualMachine;
using System.Collections.Generic;
using System.IO;

namespace Advent_of_Code.Day_07
{
    public class Amplifier
    {
        private readonly long _input;
        private readonly long _phase;
        private readonly IntcodeVirtualMachine _intcodeVirtualMachine;
        private readonly List<long> _program;
        private readonly string _filename;

        public Amplifier(long input, long phase, List<long> program, IInputProvider inputProvider = null, IOutputProvider outputProvider = null)
        {
            this._input = input;
            this._phase = phase;
            _program = program;
            _filename = Path.GetTempFileName();

            inputProvider ??= new StaticInputProvider(new List<long>() { _phase, _input });
            outputProvider ??= new FileOutputProvider(_filename);

            _intcodeVirtualMachine = new IntcodeVirtualMachine(_program, inputProvider, outputProvider);
        }

        public int Run()
        {
            _intcodeVirtualMachine.Run();
            return int.Parse(File.ReadAllText(_filename));
        }
    }
}
