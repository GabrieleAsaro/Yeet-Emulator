using YeetEmulator.Instructions;

namespace YeetEmulator.OpCodes.Handlers
{
	internal class Ret : YeetOpCodeHandler
	{
		public override void ExecuteInstruction(YeetCore core, YeetInstruction instr)
		{
			core.VMStack.Push(core.VMStack.Count == 0 ? null : core.VMStack.Pop());
			core.Index++;
		}
	}
}
