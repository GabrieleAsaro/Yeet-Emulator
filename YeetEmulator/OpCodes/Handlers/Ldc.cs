using YeetEmulator.Instructions;

namespace YeetEmulator.OpCodes.Handlers
{
	internal class Ldc : YeetOpCodeHandler
	{
		public override void ExecuteInstruction(YeetCore core, YeetInstruction instr)
		{
			core.VMStack.Push((int)instr.Operand);
			core.Index++;
		}
	}
}