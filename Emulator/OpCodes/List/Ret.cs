using Emulator.Instructions;

namespace Emulator.OpCodes.List
{
	internal class Ret : Base
	{
		public override void ExecuteInstruction(Core core, Instruction instr)
		{
			if(core.VMStack.Count == 0)
				core.VMStack.Push(null);

			object ret = core.VMStack.Pop();

			core.VMStack.Push(ret);
			core.Index++;
		}
	}
}
