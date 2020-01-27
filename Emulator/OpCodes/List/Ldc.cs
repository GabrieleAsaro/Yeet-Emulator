using Emulator.Instructions;

namespace Emulator.OpCodes.List
{
	internal class Ldc : Base
	{
		public override void ExecuteInstruction(Core core, Instruction instr)
		{
			core.VMStack.Push((int)instr.Operand);
			core.Index++;
		}
	}
}