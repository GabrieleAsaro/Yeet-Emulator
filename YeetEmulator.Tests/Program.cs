using YeetEmulator.Instructions;
using System;
using System.Collections.Generic;
using YeetEmulator;

namespace Emulator.Tests
{
	class Program
	{
		private static void Main(string[] args)
		{
			// An example of a method body, which adds the numbers 4 and 2 togheter and returns it.
			List<YeetInstruction> instruction = new List<YeetInstruction>
			{
				new YeetInstruction(YeetOpCodes.Ldc, 4),
				new YeetInstruction(YeetOpCodes.Ldc, 2),
				new YeetInstruction(YeetOpCodes.Add),
				new YeetInstruction(YeetOpCodes.Ret)
			};

			// Initialize the VM.
			YeetCore core = new YeetCore(instruction);

			// Execute and print result.
			Console.WriteLine(core.Execute());
			Console.ReadLine();
		}
	}
}