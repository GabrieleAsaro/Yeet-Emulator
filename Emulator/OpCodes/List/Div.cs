using Emulator.Instructions;

namespace Emulator.OpCodes.List
{
	internal class Div : Base
	{
		public override void ExecuteInstruction(Core core, Instruction instr)
		{
			object x = core.VMStack.Pop();
			object y = core.VMStack.Pop();

			core.VMStack.Push((int)y / (int)x);
			core.Index++;
		}
	}
}