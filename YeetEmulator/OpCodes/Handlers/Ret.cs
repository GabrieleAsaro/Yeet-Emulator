using YeetEmulator.Instructions;

namespace YeetEmulator.OpCodes.Handlers
{
	internal class Ret : YeetOpCodeHandler
	{
		public override void ExecuteInstruction(YeetCore core, YeetInstruction instr)
		{
			if(core.VMStack.Count == 0)
				core.VMStack.Push(null);

			object ret = core.VMStack.Pop();

			core.VMStack.Push(ret);
			core.Index++;
		}
	}
}
