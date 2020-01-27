using Emulator.Instructions;

namespace Emulator.OpCodes.List
{
	internal class Sub : Base
	{
		public override void ExecuteInstruction(Core core, Instruction instr)
		{
			object y = core.VMStack.Pop();
			object x = core.VMStack.Pop();

			core.VMStack.Push((int)y - (int)x);
			core.Index++;
		}
	}
}