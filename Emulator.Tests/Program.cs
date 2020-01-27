using Emulator.Instructions;
using System;
using System.Collections.Generic;

namespace Emulator.Tests
{
	class Program
	{
		/// <summary>
		/// An simple example to show how the emulator works.
		/// 
		/// We have two integers (Ldc) and we have the other instructions Add and Ret.
		/// Obviously, this will return the sum of both the integers.
		/// 
		/// </summary>
		/// <param name="args"></param>
		private static void Main(string[] args)
		{
			List<Instruction> instruction = new List<Instruction>
			{
				new Instruction(OpCodesL.Ldc, 4),
				new Instruction(OpCodesL.Ldc, 2),
				new Instruction(OpCodesL.Add),
				new Instruction(OpCodesL.Ret)
			};

			Core core = new Core(instruction);

			Console.WriteLine(core.Execute());
			Console.ReadLine();
		}
	}
}