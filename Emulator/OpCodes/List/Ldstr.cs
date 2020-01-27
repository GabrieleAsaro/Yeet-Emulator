using Emulator.Instructions;

namespace Emulator.OpCodes.List
{
	internal class Ldstr : Base
	{
		public override void ExecuteInstruction(Core core, Instruction instr)
		{
			core.VMStack.Push((string)instr.Operand);
			core.Index++;
		}
	}
}